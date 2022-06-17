namespace UFBX.Interop
{
    public partial struct SkinVertex
    {
        [NativeTypeName("uint32_t")]
        public uint weight_begin;

        [NativeTypeName("uint32_t")]
        public uint num_weights;

        [NativeTypeName("ufbx_real")]
        public Real dq_weight;
    }
}
