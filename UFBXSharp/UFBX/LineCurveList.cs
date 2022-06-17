using System;

namespace UFBX.Interop
{
    public unsafe partial struct LineCurveList
    {
        [NativeTypeName("ufbx_line_curve **")]
        public LineCurve** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
