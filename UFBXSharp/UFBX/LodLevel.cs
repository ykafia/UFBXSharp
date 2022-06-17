namespace UFBX.Interop
{
    public partial struct LodLevel
    {
        [NativeTypeName("ufbx_real")]
        public Real distance;

        [NativeTypeName("ufbx_lod_display")]
        public LodDisplay display;
    }
}
