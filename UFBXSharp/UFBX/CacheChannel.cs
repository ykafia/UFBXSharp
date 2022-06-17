namespace UFBX.Interop
{
    public partial struct CacheChannel
    {
        [NativeTypeName("ufbx_string")]
        public String name;

        [NativeTypeName("ufbx_cache_interpretation")]
        public CacheInterpretation interpretation;

        [NativeTypeName("ufbx_string")]
        public String interpretation_name;

        [NativeTypeName("ufbx_cache_frame_list")]
        public CacheFrameList frames;
    }
}
