using System;

namespace UFBX.Interop
{
    public unsafe partial struct VideoList
    {
        [NativeTypeName("ufbx_video **")]
        public Video** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
