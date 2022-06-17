namespace UFBX.Interop
{
    public unsafe partial struct PropOverride
    {
        [NativeTypeName("uint32_t")]
        public uint element_id;

        [NativeTypeName("const char *")]
        public sbyte* prop_name;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 value;

        [NativeTypeName("const char *")]
        public sbyte* value_str;

        [NativeTypeName("int64_t")]
        public long value_int;

        [NativeTypeName("uint32_t")]
        public uint internal_key;
    }
}
