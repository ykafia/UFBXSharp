using System;

namespace UFBX.Interop
{
    public unsafe partial struct AnimCurveList
    {
        [NativeTypeName("ufbx_anim_curve **")]
        public AnimCurve** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
