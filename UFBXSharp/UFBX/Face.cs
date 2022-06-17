namespace UFBX.Interop
{
    public partial struct Face
    {
        [NativeTypeName("uint32_t")]
        public uint index_begin;

        [NativeTypeName("uint32_t")]
        public uint num_indices;
    }
}
