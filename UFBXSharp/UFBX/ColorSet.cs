namespace UFBX.Interop
{
    public partial struct ColorSet
    {
        [NativeTypeName("ufbx_string")]
        public String name;

        [NativeTypeName("int32_t")]
        public int index;

        [NativeTypeName("ufbx_vertex_vec4")]
        public VertexVec4 vertex_color;
    }
}
