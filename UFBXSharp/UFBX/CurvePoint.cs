namespace UFBX.Interop
{
    public partial struct CurvePoint
    {
        [NativeTypeName("_Bool")]
        public bool valid;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 position;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 derivative;
    }
}
