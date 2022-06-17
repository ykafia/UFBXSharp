using System;

namespace UFBX.Interop
{
    public unsafe partial struct AnimLayerList
    {
        [NativeTypeName("ufbx_anim_layer **")]
        public AnimLayer** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
