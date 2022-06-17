namespace UFBX.Interop
{
    public partial struct Keyframe
    {
        public double time;

        [NativeTypeName("ufbx_real")]
        public Real value;

        [NativeTypeName("ufbx_interpolation")]
        public Interpolation interpolation;

        [NativeTypeName("ufbx_tangent")]
        public Tangent left;

        [NativeTypeName("ufbx_tangent")]
        public Tangent right;
    }
}
