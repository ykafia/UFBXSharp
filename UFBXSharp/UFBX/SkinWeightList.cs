using System;

namespace UFBX.Interop
{
    public unsafe partial struct SkinWeightList
    {
        [NativeTypeName("ufbx_skin_weight *")]
        public SkinWeight* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
