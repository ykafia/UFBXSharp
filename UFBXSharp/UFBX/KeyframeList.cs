using System;

namespace UFBX.Interop
{
    public unsafe partial struct KeyframeList
    {
        [NativeTypeName("ufbx_keyframe *")]
        public Keyframe* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
