using System;

namespace UFBX.Interop
{
    public unsafe partial struct AnimPropList
    {
        [NativeTypeName("ufbx_anim_prop *")]
        public AnimProp* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
