namespace UFBX.Interop
{
    public unsafe partial struct AnimProp
    {
        [NativeTypeName("ufbx_element *")]
        public Element* element;

        [NativeTypeName("uint32_t")]
        public uint internal_key;

        [NativeTypeName("ufbx_string")]
        public String prop_name;

        [NativeTypeName("ufbx_anim_value *")]
        public AnimValue* anim_value;
    }
}
