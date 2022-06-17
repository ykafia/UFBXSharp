using System;

namespace UFBX.Interop
{
    public unsafe partial struct MeshList
    {
        [NativeTypeName("ufbx_mesh **")]
        public Mesh** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
