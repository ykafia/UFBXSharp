namespace UFBX.Interop
{
    public unsafe partial struct TextureLayer
    {
        [NativeTypeName("ufbx_texture *")]
        public Texture* texture;

        [NativeTypeName("ufbx_blend_mode")]
        public BlendMode blend_mode;

        [NativeTypeName("ufbx_real")]
        public Real alpha;
    }
}
