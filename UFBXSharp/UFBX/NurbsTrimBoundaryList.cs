using System;

namespace UFBX.Interop
{
    public unsafe partial struct NurbsTrimBoundaryList
    {
        [NativeTypeName("ufbx_nurbs_trim_boundary **")]
        public NurbsTrimBoundary** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
