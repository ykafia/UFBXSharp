using System;

namespace UFBX.Interop
{
    public unsafe partial struct SkinVertexList
    {
        [NativeTypeName("ufbx_skin_vertex *")]
        public SkinVertex* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
