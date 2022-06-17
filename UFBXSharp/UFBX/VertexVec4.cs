using System;

namespace UFBX.Interop
{
    public unsafe partial struct VertexVec4
    {
        [NativeTypeName("ufbx_vec4 *")]
        public Vec4* data;

        [NativeTypeName("int32_t *")]
        public int* indices;

        [NativeTypeName("size_t")]
        public UIntPtr num_values;

        [NativeTypeName("size_t")]
        public UIntPtr value_reals;

        [NativeTypeName("_Bool")]
        public bool unique_per_vertex;
    }
}
