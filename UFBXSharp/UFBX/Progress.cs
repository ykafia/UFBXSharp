namespace UFBX.Interop
{
    public partial struct Progress
    {
        [NativeTypeName("uint64_t")]
        public ulong bytes_read;

        [NativeTypeName("uint64_t")]
        public ulong bytes_total;
    }
}
