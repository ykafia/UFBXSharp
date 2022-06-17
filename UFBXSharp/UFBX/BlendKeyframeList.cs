using System;

namespace UFBX.Interop
{
    public unsafe partial struct BlendKeyframeList
    {
        [NativeTypeName("ufbx_blend_keyframe *")]
        public BlendKeyframe* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
