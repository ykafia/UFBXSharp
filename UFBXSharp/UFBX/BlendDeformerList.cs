using System;

namespace UFBX.Interop
{
    public unsafe partial struct BlendDeformerList
    {
        [NativeTypeName("ufbx_blend_deformer **")]
        public BlendDeformer** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
