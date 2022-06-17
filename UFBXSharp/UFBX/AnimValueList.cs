using System;

namespace UFBX.Interop
{
    public unsafe partial struct AnimValueList
    {
        [NativeTypeName("ufbx_anim_value **")]
        public AnimValue** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
