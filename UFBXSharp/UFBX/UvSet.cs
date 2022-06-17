namespace UFBX.Interop
{
    public partial struct UvSet
    {
        [NativeTypeName("ufbx_string")]
        public String name;

        [NativeTypeName("int32_t")]
        public int index;

        [NativeTypeName("ufbx_vertex_vec2")]
        public VertexVec2 vertex_uv;

        [NativeTypeName("ufbx_vertex_vec3")]
        public VertexVec3 vertex_tangent;

        [NativeTypeName("ufbx_vertex_vec3")]
        public VertexVec3 vertex_bitangent;
    }
}
