using System;

namespace UFBX.Interop
{
    public unsafe partial struct LightList
    {
        [NativeTypeName("ufbx_light **")]
        public Light** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
