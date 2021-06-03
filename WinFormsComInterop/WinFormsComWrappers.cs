﻿extern alias primitives;
extern alias drawing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static primitives::Interop;
using static primitives::Interop.UiaCore;

namespace WinFormsComInterop
{
    public unsafe class WinFormsComWrappers : ComWrappers
    {
        static ComWrappers.ComInterfaceEntry* wrapperEntry;
        static ComWrappers.ComInterfaceEntry* streamEntry;

        internal static Guid IID_IRawElementProviderSimple = new Guid("D6DD68D1-86FD-4332-8666-9ABEDEA2D24C");

        internal static Guid IID_IOleWindow = new Guid("00000114-0000-0000-C000-000000000046");
        internal static Guid IID_IStream = new Guid("0000000C-0000-0000-C000-000000000046");
        internal static Guid IID_IPersistStream = new Guid("00000109-0000-0000-C000-000000000046");

        // This class only exposes IDispatch and the vtable is always the same.
        // The below isn't the most efficient but it is reasonable for prototyping.
        // If additional interfaces want to be exposed, add them here.
        static WinFormsComWrappers()
        {
            wrapperEntry = CreateGenericEntry();
            streamEntry = CreateStreamEntry();
        }

        private static ComInterfaceEntry* CreateGenericEntry()
        {
            CreateIRawElementProviderSimpleVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IRawElementProviderSimple;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        private static ComInterfaceEntry* CreateStreamEntry()
        {
            CreateIStreamSimpleVtbl(out var vtbl);

            var comInterfaceEntryMemory = RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(ComInterfaceEntry) * 2);
            wrapperEntry = (ComInterfaceEntry*)comInterfaceEntryMemory.ToPointer();
            wrapperEntry->IID = IID_IStream;
            wrapperEntry->Vtable = vtbl;
            return wrapperEntry;
        }

        private static void CreateIRawElementProviderSimpleVtbl(out IntPtr vtbl)
        {
            var vtblRaw = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(IntPtr) * 7);
            GetIUnknownImpl(out vtblRaw[0], out vtblRaw[1], out vtblRaw[2]);

            vtblRaw[3] = (IntPtr)(delegate* unmanaged<IntPtr, ProviderOptions*, int>)&IRawElementProviderSimpleVtbl.GetProviderOptionsInternal;
            vtblRaw[4] = (IntPtr)(delegate* unmanaged<IntPtr, UIA, IntPtr*, int>)&IRawElementProviderSimpleVtbl.GetPatternProviderInternal;
            vtblRaw[5] = (IntPtr)(delegate* unmanaged<IntPtr, UIA, IntPtr*, int>)&IRawElementProviderSimpleVtbl.GetPropertyValueInternal;
            vtblRaw[6] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderSimpleVtbl.HostRawElementProviderInternal;

            vtbl = (IntPtr)vtblRaw;
        }

        private static void CreateIStreamSimpleVtbl(out IntPtr vtbl)
        {
            var vtblRaw = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(WinFormsComWrappers), sizeof(IntPtr) * 12);
            GetIUnknownImpl(out vtblRaw[0], out vtblRaw[1], out vtblRaw[2]);

            vtblRaw[3] = (IntPtr)(delegate* unmanaged<IntPtr, byte*, uint, uint*, int>)&IStreamVtbl.Read;
            vtblRaw[4] = (IntPtr)(delegate* unmanaged<IntPtr, byte*, uint, uint*, int>)&IStreamVtbl.Write;
            vtblRaw[5] = (IntPtr)(delegate* unmanaged<IntPtr, long, System.IO.SeekOrigin, ulong*, int>)&IStreamVtbl.Seek;
            vtblRaw[6] = (IntPtr)(delegate* unmanaged<IntPtr, ulong, int>)&IStreamVtbl.SetSize;
            vtblRaw[7] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, ulong, ulong*, ulong*, int>)&IStreamVtbl.CopyTo;
            vtblRaw[8] = (IntPtr)(delegate* unmanaged<IntPtr, uint, int>)&IStreamVtbl.Commit;
            vtblRaw[9] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&IStreamVtbl.Revert;
            vtblRaw[10] = (IntPtr)(delegate* unmanaged<IntPtr, ulong, ulong, uint, int>)&IStreamVtbl.LockRegion;
            vtblRaw[11] = (IntPtr)(delegate* unmanaged<IntPtr, ulong, ulong, uint, int>)&IStreamVtbl.UnlockRegion;
            vtblRaw[12] = (IntPtr)(delegate* unmanaged<IntPtr, drawing::Interop.Ole32.STATSTG*, drawing::Interop.Ole32.STATFLAG, int>)&IStreamVtbl.Stat;
            vtblRaw[13] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&IStreamVtbl.Clone;

            vtbl = (IntPtr)vtblRaw;
        }

        public static WinFormsComWrappers Instance { get; } = new WinFormsComWrappers();

        protected override unsafe ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count)
        {
            // count = 0;
            // return null;
            if (obj is drawing::Interop.Ole32.IStream)
            {
                count = 1;
                return streamEntry;
            }

            var interfaces = obj.GetType().GetInterfaces();
            if (interfaces.Length == 1 && interfaces[0].GUID.ToString() == "0000000C-0000-0000-C000-000000000046")
            {
                count = 1;
                return streamEntry;
            }

            count = 1;
            return wrapperEntry;
        }

        protected override object CreateObject(IntPtr externalComObject, CreateObjectFlags flags)
        {
            // Return NULL works,
            //return null;
            GetIUnknownImpl(out IntPtr fpQueryInteface, out IntPtr fpAddRef, out IntPtr fpRelease);
            if (((IntPtr*)((IntPtr*)externalComObject)[0])[0] == fpQueryInteface)
            {
                return ComWrappers.ComInterfaceDispatch.GetInstance<object>((ComWrappers.ComInterfaceDispatch*)externalComObject);
            }

            // Return object does not works yet.
            return new IExternalObject(externalComObject);
        }

        protected override void ReleaseObjects(System.Collections.IEnumerable objects)
        {
        }
    }
}
