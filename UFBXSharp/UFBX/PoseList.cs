using System;

namespace UFBX.Interop
{
    public unsafe partial struct PoseList
    {
        [NativeTypeName("ufbx_pose **")]
        public Pose** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
