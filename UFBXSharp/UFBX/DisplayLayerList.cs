using System;

namespace UFBX.Interop
{
    public unsafe partial struct DisplayLayerList
    {
        [NativeTypeName("ufbx_display_layer **")]
        public DisplayLayer** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
