namespace UFBX.Interop
{
    public partial struct GeometryCache
    {
        [NativeTypeName("ufbx_string")]
        public String root_filename;

        [NativeTypeName("ufbx_cache_channel_list")]
        public CacheChannelList channels;

        [NativeTypeName("ufbx_cache_frame_list")]
        public CacheFrameList frames;

        [NativeTypeName("ufbx_string_list")]
        public StringList extra_info;
    }
}
