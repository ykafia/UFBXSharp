using System;

namespace UFBX.Interop
{
    public unsafe partial struct LodLevelList
    {
        [NativeTypeName("ufbx_lod_level *")]
        public LodLevel* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
