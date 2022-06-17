using System;

namespace UFBX.Interop
{
    public unsafe partial struct MeshMaterialList
    {
        [NativeTypeName("ufbx_mesh_material *")]
        public MeshMaterial* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
