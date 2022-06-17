using System;

namespace UFBX.Interop
{
    public unsafe partial struct SkinDeformerList
    {
        [NativeTypeName("ufbx_skin_deformer **")]
        public SkinDeformer** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
