using System;

namespace UFBX.Interop
{
    public unsafe partial struct NurbsTrimSurfaceList
    {
        [NativeTypeName("ufbx_nurbs_trim_surface **")]
        public NurbsTrimSurface** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
