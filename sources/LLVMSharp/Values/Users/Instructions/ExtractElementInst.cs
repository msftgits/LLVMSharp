// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using LLVMSharp.Interop;

namespace LLVMSharp
{
    public sealed class ExtractElementInst : Instruction
    {
        internal ExtractElementInst(LLVMValueRef handle) : base(handle.IsAExtractElementInst)
        {
        }
    }
}
