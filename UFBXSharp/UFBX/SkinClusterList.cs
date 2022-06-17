using System;

namespace UFBX.Interop
{
    public unsafe partial struct SkinClusterList
    {
        [NativeTypeName("ufbx_skin_cluster **")]
        public SkinCluster** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
