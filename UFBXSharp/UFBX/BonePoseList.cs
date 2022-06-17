using System;

namespace UFBX.Interop
{
    public unsafe partial struct BonePoseList
    {
        [NativeTypeName("ufbx_bone_pose *")]
        public BonePose* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
