using System;

namespace UFBX.Interop
{
    public unsafe partial struct MeshMaterial
    {
        [NativeTypeName("ufbx_material *")]
        public Material* material;

        [NativeTypeName("size_t")]
        public UIntPtr num_faces;

        [NativeTypeName("size_t")]
        public UIntPtr num_triangles;

        [NativeTypeName("int32_t *")]
        public int* face_indices;
    }
}
