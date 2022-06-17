namespace UFBX.Interop
{
    public unsafe partial struct BlendKeyframe
    {
        [NativeTypeName("ufbx_blend_shape *")]
        public BlendShape* shape;

        [NativeTypeName("ufbx_real")]
        public Real target_weight;

        [NativeTypeName("ufbx_real")]
        public Real effective_weight;
    }
}
