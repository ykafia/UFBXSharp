using System;

namespace UFBX.Interop
{
    public unsafe partial struct BoneList
    {
        [NativeTypeName("ufbx_bone **")]
        public Bone** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
