// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using System;

namespace LLVMSharp.Interop
{
    public unsafe partial struct LLVMErrorTypeId
    {
        public LLVMErrorTypeId(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;

        public static explicit operator LLVMErrorTypeId(void* value)
        {
            return new LLVMErrorTypeId((IntPtr)value);
        }

        public static implicit operator void*(LLVMErrorTypeId value)
        {
            return (void*)value.Pointer;
        }
    }
}
