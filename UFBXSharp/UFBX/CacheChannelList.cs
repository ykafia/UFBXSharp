using System;

namespace UFBX.Interop
{
    public unsafe partial struct CacheChannelList
    {
        [NativeTypeName("ufbx_cache_channel *")]
        public CacheChannel* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
