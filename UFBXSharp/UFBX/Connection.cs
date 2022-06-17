namespace UFBX.Interop
{
    public unsafe partial struct Connection
    {
        [NativeTypeName("ufbx_element *")]
        public Element* src;

        [NativeTypeName("ufbx_element *")]
        public Element* dst;

        [NativeTypeName("ufbx_string")]
        public String src_prop;

        [NativeTypeName("ufbx_string")]
        public String dst_prop;
    }
}
