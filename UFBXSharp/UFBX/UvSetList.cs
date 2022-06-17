using System;

namespace UFBX.Interop
{
    public unsafe partial struct UvSetList
    {
        [NativeTypeName("ufbx_uv_set *")]
        public UvSet* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
