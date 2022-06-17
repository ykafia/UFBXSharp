namespace UFBX.Interop
{
    public unsafe partial struct MaterialTexture
    {
        [NativeTypeName("ufbx_string")]
        public String material_prop;

        [NativeTypeName("ufbx_string")]
        public String shader_prop;

        [NativeTypeName("ufbx_texture *")]
        public Texture* texture;
    }
}
