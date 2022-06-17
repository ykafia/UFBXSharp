namespace UFBX.Interop
{
    public partial struct SkinWeight
    {
        [NativeTypeName("uint32_t")]
        public uint cluster_index;

        [NativeTypeName("ufbx_real")]
        public Real weight;
    }
}
