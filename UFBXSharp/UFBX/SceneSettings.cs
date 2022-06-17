namespace UFBX.Interop
{
    public partial struct SceneSettings
    {
        [NativeTypeName("ufbx_props")]
        public Props props;

        [NativeTypeName("ufbx_coordinate_axes")]
        public CoordinateAxes axes;

        [NativeTypeName("ufbx_real")]
        public Real unit_meters;

        public double frames_per_second;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 ambient_color;

        [NativeTypeName("ufbx_string")]
        public String default_camera;

        [NativeTypeName("ufbx_time_mode")]
        public TimeMode time_mode;

        [NativeTypeName("ufbx_time_protocol")]
        public TimeProtocol time_protocol;

        [NativeTypeName("ufbx_snap_mode")]
        public SnapMode snap_mode;

        [NativeTypeName("ufbx_coordinate_axis")]
        public CoordinateAxis original_axis_up;

        [NativeTypeName("ufbx_real")]
        public Real original_unit_meters;
    }
}
