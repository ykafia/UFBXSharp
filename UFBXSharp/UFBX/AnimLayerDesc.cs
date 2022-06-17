namespace UFBX.Interop
{
    public unsafe partial struct AnimLayerDesc
    {
        [NativeTypeName("ufbx_anim_layer *")]
        public AnimLayer* layer;

        [NativeTypeName("ufbx_real")]
        public Real weight;
    }
}
