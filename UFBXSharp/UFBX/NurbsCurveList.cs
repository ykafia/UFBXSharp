using System;

namespace UFBX.Interop
{
    public unsafe partial struct NurbsCurveList
    {
        [NativeTypeName("ufbx_nurbs_curve **")]
        public NurbsCurve** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
