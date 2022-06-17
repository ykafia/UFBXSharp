using System;

namespace UFBX.Interop
{
    public unsafe partial struct TextureList
    {
        [NativeTypeName("ufbx_texture **")]
        public Texture** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
