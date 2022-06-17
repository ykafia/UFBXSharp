using System;

namespace UFBX.Interop
{
    public unsafe partial struct Vec4List
    {
        [NativeTypeName("ufbx_vec4 *")]
        public Vec4* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
