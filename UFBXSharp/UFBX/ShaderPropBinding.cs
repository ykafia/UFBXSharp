namespace UFBX.Interop
{
    public partial struct ShaderPropBinding
    {
        [NativeTypeName("ufbx_string")]
        public String shader_prop;

        [NativeTypeName("ufbx_string")]
        public String material_prop;
    }
}
