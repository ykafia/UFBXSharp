namespace UFBX.Interop
{
    public partial struct SurfacePoint
    {
        [NativeTypeName("_Bool")]
        public bool valid;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 position;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 derivative_u;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 derivative_v;
    }
}
