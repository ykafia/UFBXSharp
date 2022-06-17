using System;

namespace UFBX.Interop
{
    public unsafe partial struct AnimStackList
    {
        [NativeTypeName("ufbx_anim_stack **")]
        public AnimStack** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
