﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace WinFormsComInterop.SourceGenerator
{
    /// <summary>
    /// Generator for COM interface proxies, used by ComWrappers.
    /// </summary>
    [Generator]
    public class Generator : ISourceGenerator
    {
        private const string AttributeSource = @"// <auto-generated>
// Code generated by COM interface proxies Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
#nullable disable

[System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple=true)]
internal sealed class ComCallableWrapperAttribute: System.Attribute
{
    public ComCallableWrapperAttribute(System.Type interfaceType) => this.InterfaceType = interfaceType;

    public System.Type InterfaceType { get; }
}
";

        private static string ComCallableWrapperAttributeName = "ComCallableWrapperAttribute";

        public void Initialize(GeneratorInitializationContext context)
        {
            context.RegisterForPostInitialization((pi) => pi.AddSource("ComProxyAttribute.cs", AttributeSource));
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }

        public void Execute(GeneratorExecutionContext context)
        {
#if DEBUG
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                //System.Diagnostics.Debugger.Launch();
            }
#endif 
            // Retrieve the populated receiver
            if (!(context.SyntaxContextReceiver is SyntaxReceiver receiver))
            {
                return;
            }

            //context.Compilation.
            foreach (var classSymbol in receiver.ClassDeclarations)
            {
                var key = (INamedTypeSymbol)classSymbol.Type;
                var sourceCode = ProcessClassDeclaration(classSymbol);
                context.AddSource($"{key.ToDisplayString().Replace(".", "_")}_comproxy.cs", SourceText.From(sourceCode, Encoding.UTF8));
            }
        }

        private string ProcessClassDeclaration(ClassDeclaration classSymbol)
        {
            string namespaceName = classSymbol.Type.ContainingNamespace.ToDisplayString();
            IndentedStringBuilder source = new IndentedStringBuilder($@"// <auto-generated>
// Code generated by COM Proxy Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
#nullable enable
using ComInterfaceDispatch = System.Runtime.InteropServices.ComWrappers.ComInterfaceDispatch;

namespace {namespaceName}
{{
");
            var proxyDeclarations = classSymbol.Type.GetAttributes().Where(ad => ad.AttributeClass?.ToDisplayString() == ComCallableWrapperAttributeName);
            foreach (var proxyAttribute in proxyDeclarations)
            {
                var overridenNameOpt = proxyAttribute.ConstructorArguments.FirstOrDefault().Value as INamedTypeSymbol;
                if (overridenNameOpt == null)
                {
                    continue;
                }

                source.PushIndent();
                source.AppendLine("[System.Runtime.Versioning.SupportedOSPlatform(\"windows\")]");
                source.AppendLine($"partial unsafe class {overridenNameOpt.Name}Proxy");
                source.AppendLine("{");
                source.PushIndent();
                foreach (var member in overridenNameOpt.GetMembers())
                {
                    var preserveSigAttribute = member.GetAttributes().FirstOrDefault(ad => ad.AttributeClass?.ToDisplayString() == "System.Runtime.InteropServices.PreserveSigAttribute");
                    var preserveSignature = preserveSigAttribute != null;

                    switch (member)
                    {
                        case IMethodSymbol methodSymbol:
                            {
                                var context = new MethodGenerationContext { Method = methodSymbol, PreserveSignature = preserveSignature };
                                GenerateMethod(source, overridenNameOpt, "", context);
                            }
                            break;
                        case IPropertySymbol propertySymbol:
                            break;
                    }
                }

                source.PopIndent();
                source.AppendLine("}");
                source.PopIndent();
            }

            source.Append("}");
            return source.ToString();
        }

        private Marshaller CreateMarshaller(IParameterSymbol parameterSymbol)
        {
            Marshaller marshaller = CreateMarshaller(parameterSymbol.Type);
            marshaller.Name = parameterSymbol.Name;
            marshaller.Type = parameterSymbol.Type;
            marshaller.RefKind = parameterSymbol.RefKind;
            marshaller.Index = parameterSymbol.Ordinal;
            return marshaller;
        }

        private Marshaller CreateMarshaller(ITypeSymbol parameterSymbol)
        {
            if (parameterSymbol.IsEnum())
            {
                return new EnumMarshaller();
            }

            if (parameterSymbol.TypeKind == TypeKind.Interface || parameterSymbol.SpecialType == SpecialType.System_Object)
            {
                return new ComInterfaceMarshaller();
            }

            return new BlittableMarshaller();
        }

        private void GenerateMethod(IndentedStringBuilder source, INamedTypeSymbol interfaceSymbol, string alias, MethodGenerationContext context)
        {
            source.AppendLine("[System.Runtime.InteropServices.UnmanagedCallersOnly]");
            var method = context.Method;
            var marshallers = method.Parameters.Select(_ =>
            {
                var marshaller = CreateMarshaller(_);
                return marshaller;
            });
            var preserveSignature = context.PreserveSignature;
            var parametersList = marshallers.Select(_ => _.GetParameterDeclaration()).ToList();
            parametersList.Insert(0, "System.IntPtr thisPtr");
            if (!preserveSignature)
            {
                if (method.ReturnType.SpecialType != SpecialType.System_Void)
                {
                    parametersList.Add("System.IntPtr* retVal");
                }
            }

            var parametersListString = string.Join(", ", parametersList);
            source.AppendLine($"public static int {method.Name}({parametersListString})");
            source.AppendLine("{");
            source.PushIndent();

            source.AppendLine("try");
            source.AppendLine("{");
            source.PushIndent();

            source.AppendLine($"var inst = ComInterfaceDispatch.GetInstance<{interfaceSymbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)}>((ComInterfaceDispatch*)thisPtr);");
            foreach (var p in marshallers)
            {
                p.DeclareLocalParameter(source);
            }
            var parametersInvocationList = string.Join(", ", marshallers.Select(_ => _.GetParameterInvocation()));

            if (!preserveSignature)
            {
                if (method.ReturnType.SpecialType == SpecialType.System_Void)
                {
                    source.AppendLine($"inst.{method.Name}({parametersInvocationList});");
                }
                else
                {
                    if (method.MethodKind == MethodKind.PropertyGet)
                    {
                        source.AppendLine($"*retVal = Marshal.GetIUnknownForObject(inst.{method.AssociatedSymbol.Name});");
                    }
                    else
                    {
                        source.AppendLine($"*retVal = Marshal.GetIUnknownForObject(inst.{method.Name}({parametersInvocationList}));");
                    }
                }
            }
            else
            {
                source.AppendLine($"return (int)inst.{method.Name}({parametersInvocationList});");
            }

            source.PopIndent();
            source.AppendLine("}");
            source.AppendLine("catch (System.Exception __e)");
            source.AppendLine("{");
            source.PushIndent();
            source.AppendLine("return __e.HResult;");
            source.PopIndent();
            source.AppendLine("}");
            if (!preserveSignature)
            {
                source.AppendLine();
                source.AppendLine("return 0; // S_OK;");
            }

            source.PopIndent();
            source.AppendLine("}");
        }

        internal class ClassDeclaration
        {
            public ITypeSymbol Type { get; set; }

            public string Alias { get; set; }
        }

        internal class SyntaxReceiver : ISyntaxContextReceiver
        {
            public List<ClassDeclaration> ClassDeclarations { get; } = new List<ClassDeclaration>();

            public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
            {
                // any field with at least one attribute is a candidate for property generation
                if (context.Node is ClassDeclarationSyntax classDeclarationSyntax
                    && classDeclarationSyntax.AttributeLists.Count > 0)
                {
                    // Get the symbol being declared by the field, and keep it if its annotated
                    var classSymbol = context.SemanticModel.GetDeclaredSymbol(context.Node) as ITypeSymbol;
                    if (classSymbol == null)
                    {
                        return;
                    }

                    if (classSymbol.GetAttributes().Any(ad => ad.AttributeClass?.ToDisplayString() == ComCallableWrapperAttributeName))
                    {
                        var argumentExpression = classDeclarationSyntax.AttributeLists[0].Attributes[0].ArgumentList.Arguments[0].Expression as TypeOfExpressionSyntax;
                        var typeNameSyntax = argumentExpression.Type as QualifiedNameSyntax;
                        var alias = "";
                        this.ClassDeclarations.Add(new ClassDeclaration { Type = classSymbol, Alias = alias });
                    }
                }
            }
        }
    }
}
