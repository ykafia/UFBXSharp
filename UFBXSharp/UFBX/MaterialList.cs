using System;

namespace UFBX.Interop
{
    public unsafe partial struct MaterialList
    {
        [NativeTypeName("ufbx_material **")]
        public Material** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
