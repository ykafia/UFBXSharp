namespace UFBX.Interop
{
    public unsafe partial struct MaterialMap
    {
        [NativeTypeName("_Bool")]
        public bool has_value;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 value;

        [NativeTypeName("int64_t")]
        public long value_int;

        [NativeTypeName("ufbx_texture *")]
        public Texture* texture;
    }
}
