namespace UFBX.Interop
{
    public partial struct CacheFrame
    {
        [NativeTypeName("ufbx_string")]
        public String channel;

        public double time;

        [NativeTypeName("ufbx_string")]
        public String filename;

        [NativeTypeName("ufbx_cache_file_format")]
        public CacheFileFormat file_format;

        [NativeTypeName("ufbx_cache_data_format")]
        public CacheDataFormat data_format;

        [NativeTypeName("ufbx_cache_data_encoding")]
        public CacheDataEncoding data_encoding;

        [NativeTypeName("uint64_t")]
        public ulong data_offset;

        [NativeTypeName("uint32_t")]
        public uint data_count;

        [NativeTypeName("uint32_t")]
        public uint data_element_bytes;

        [NativeTypeName("uint64_t")]
        public ulong data_total_bytes;
    }
}
