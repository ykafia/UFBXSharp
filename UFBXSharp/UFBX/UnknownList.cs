using System;

namespace UFBX.Interop
{
    public unsafe partial struct UnknownList
    {
        public ufbx_unknown** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
