namespace UFBX.Interop
{
    public unsafe partial struct InflateRetainub
    {
        [NativeTypeName("_Bool")]
        public bool initialized;

        [NativeTypeName("uint64_t[512]")]
        public fixed ulong data[512];
    }
}
