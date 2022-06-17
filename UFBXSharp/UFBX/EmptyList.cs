using System;

namespace UFBX.Interop
{
    public unsafe partial struct EmptyList
    {
        [NativeTypeName("ufbx_empty **")]
        public Empty** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
