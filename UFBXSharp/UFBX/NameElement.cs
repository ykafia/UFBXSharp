namespace UFBX.Interop
{
    public unsafe partial struct NameElement
    {
        [NativeTypeName("ufbx_string")]
        public String name;

        [NativeTypeName("ufbx_element_type")]
        public ElementType type;

        [NativeTypeName("uint32_t")]
        public uint internal_key;

        [NativeTypeName("ufbx_element *")]
        public Element* element;
    }
}
