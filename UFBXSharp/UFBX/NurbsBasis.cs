using System;

namespace UFBX.Interop
{
    public partial struct NurbsBasis
    {
        [NativeTypeName("uint32_t")]
        public uint order;

        [NativeTypeName("ufbx_nurbs_topology")]
        public NurbsTopology topology;

        [NativeTypeName("ufbx_real_list")]
        public RealList knot_vector;

        [NativeTypeName("ufbx_real")]
        public Real t_min;

        [NativeTypeName("ufbx_real")]
        public Real t_max;

        [NativeTypeName("ufbx_real_list")]
        public RealList spans;

        [NativeTypeName("_Bool")]
        public bool is_2d;

        [NativeTypeName("size_t")]
        public UIntPtr num_wrap_control_points;

        [NativeTypeName("_Bool")]
        public bool valid;
    }
}
