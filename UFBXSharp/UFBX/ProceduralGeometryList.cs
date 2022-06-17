using System;

namespace UFBX.Interop
{
    public unsafe partial struct ProceduralGeometryList
    {
        [NativeTypeName("ufbx_procedural_geometry **")]
        public ProceduralGeometry** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
