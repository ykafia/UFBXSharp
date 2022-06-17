using System;

namespace UFBX.Interop
{
    public unsafe partial struct CacheDeformerList
    {
        [NativeTypeName("ufbx_cache_deformer **")]
        public CacheDeformer** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
