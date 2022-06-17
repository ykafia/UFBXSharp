using System;

namespace UFBX.Interop
{
    public unsafe partial struct VertexVec2
    {
        [NativeTypeName("ufbx_vec2 *")]
        public Vec2* data;

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
