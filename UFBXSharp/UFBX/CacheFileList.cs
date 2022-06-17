using System;

namespace UFBX.Interop
{
    public unsafe partial struct CacheFileList
    {
        [NativeTypeName("ufbx_cache_file **")]
        public CacheFile** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
