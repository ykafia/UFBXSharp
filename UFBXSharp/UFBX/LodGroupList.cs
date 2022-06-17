using System;

namespace UFBX.Interop
{
    public unsafe partial struct LodGroupList
    {
        [NativeTypeName("ufbx_lod_group **")]
        public LodGroup** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
