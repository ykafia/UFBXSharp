namespace UFBX.Interop
{
    public partial struct Element
    {
        [NativeTypeName("ufbx_string")]
        public String name;

        [NativeTypeName("ufbx_props")]
        public Props props;

        [NativeTypeName("uint32_t")]
        public uint element_id;

        [NativeTypeName("uint32_t")]
        public uint typed_id;

        [NativeTypeName("ufbx_node_list")]
        public NodeList instances;

        [NativeTypeName("ufbx_element_type")]
        public ElementType type;

        public ufbx_connection_list connections_src;

        public ufbx_connection_list connections_dst;
    }
}
