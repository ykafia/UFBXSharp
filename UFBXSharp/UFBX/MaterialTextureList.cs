using System;

namespace UFBX.Interop
{
    public unsafe partial struct MaterialTextureList
    {
        [NativeTypeName("ufbx_material_texture *")]
        public MaterialTexture* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
