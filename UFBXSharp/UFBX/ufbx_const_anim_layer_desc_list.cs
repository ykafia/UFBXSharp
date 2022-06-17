using System;

namespace UFBX.Interop
{
    public unsafe partial struct ufbx_const_anim_layer_desc_list
    {
        [NativeTypeName("const ufbx_anim_layer_desc *")]
        public AnimLayerDesc* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
