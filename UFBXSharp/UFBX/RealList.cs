using System;

namespace UFBX.Interop
{
    public unsafe partial struct RealList
    {
        [NativeTypeName("ufbx_real *")]
        public Real* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
