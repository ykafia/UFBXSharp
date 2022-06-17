namespace UFBX.Interop
{
    public partial struct TessellateOpts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        [NativeTypeName("ufbx_allocator")]
        public Allocator temp_allocator;

        [NativeTypeName("ufbx_allocator")]
        public Allocator result_allocator;

        [NativeTypeName("int32_t")]
        public int span_subdivision_u;

        [NativeTypeName("int32_t")]
        public int span_subdivision_v;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }
}
