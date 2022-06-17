using System;

namespace UFBX.Interop
{
    public unsafe partial struct CacheFrameList
    {
        [NativeTypeName("ufbx_cache_frame *")]
        public CacheFrame* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
