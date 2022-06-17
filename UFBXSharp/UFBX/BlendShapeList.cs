using System;

namespace UFBX.Interop
{
    public unsafe partial struct BlendShapeList
    {
        [NativeTypeName("ufbx_blend_shape **")]
        public BlendShape** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
