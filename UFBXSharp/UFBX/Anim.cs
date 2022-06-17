namespace UFBX.Interop
{
    public partial struct Anim
    {
        public ufbx_const_anim_layer_desc_list layers;

        [NativeTypeName("ufbx_const_prop_override_list")]
        public ConstPropOverrideList prop_overrides;

        [NativeTypeName("_Bool")]
        public bool ignore_connections;
    }
}
