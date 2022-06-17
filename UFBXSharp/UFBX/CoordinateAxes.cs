namespace UFBX.Interop
{
    public partial struct CoordinateAxes
    {
        [NativeTypeName("ufbx_coordinate_axis")]
        public CoordinateAxis right;

        [NativeTypeName("ufbx_coordinate_axis")]
        public CoordinateAxis up;

        [NativeTypeName("ufbx_coordinate_axis")]
        public CoordinateAxis front;
    }
}
