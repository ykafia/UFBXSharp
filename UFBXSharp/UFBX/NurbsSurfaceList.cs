using System;

namespace UFBX.Interop
{
    public unsafe partial struct NurbsSurfaceList
    {
        [NativeTypeName("ufbx_nurbs_surface **")]
        public NurbsSurface** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
