namespace UFBX.Interop
{
    public partial struct SubdivideOpts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        [NativeTypeName("ufbx_allocator")]
        public Allocator temp_allocator;

        [NativeTypeName("ufbx_allocator")]
        public Allocator result_allocator;

        [NativeTypeName("ufbx_subdivision_boundary")]
        public SubdivisionBoundary boundary;

        [NativeTypeName("ufbx_subdivision_boundary")]
        public SubdivisionBoundary uv_boundary;

        [NativeTypeName("_Bool")]
        public bool ignore_normals;

        [NativeTypeName("_Bool")]
        public bool interpolate_normals;

        [NativeTypeName("_Bool")]
        public bool interpolate_tangents;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }
}
