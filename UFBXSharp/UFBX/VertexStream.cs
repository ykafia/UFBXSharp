using System;

namespace UFBX.Interop
{
    public unsafe partial struct VertexStream
    {
        [NativeTypeName("const void *")]
        public void* data;

        [NativeTypeName("size_t")]
        public UIntPtr vertex_size;
    }
}
