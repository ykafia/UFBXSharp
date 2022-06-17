namespace UFBX.Interop
{
    public partial struct LineSegment
    {
        [NativeTypeName("uint32_t")]
        public uint index_begin;

        [NativeTypeName("uint32_t")]
        public uint num_indices;
    }
}
