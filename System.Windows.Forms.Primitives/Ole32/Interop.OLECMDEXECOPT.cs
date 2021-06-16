﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

public static partial class Interop
{
    public static partial class Ole32
    {
        public enum OLECMDEXECOPT : uint
        {
            DODEFAULT = 0,
            PROMPTUSER = 1,
            DONTPROMPTUSER = 2,
            SHOWHELP = 3
        }
    }
}
