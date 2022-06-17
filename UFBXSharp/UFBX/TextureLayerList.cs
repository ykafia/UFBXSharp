using System;

namespace UFBX.Interop
{
    public unsafe partial struct TextureLayerList
    {
        [NativeTypeName("ufbx_texture_layer *")]
        public TextureLayer* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
