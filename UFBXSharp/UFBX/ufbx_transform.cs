namespace UFBX.Interop
{
    public partial struct ufbx_transform
    {
        [NativeTypeName("ufbx_vec3")]
        public Vec3 translation;

        [NativeTypeName("ufbx_quat")]
        public Quat rotation;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 scale;
    }
}
