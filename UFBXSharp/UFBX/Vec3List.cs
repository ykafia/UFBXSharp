using System;

namespace UFBX.Interop
{
    public unsafe partial struct Vec3List
    {
        [NativeTypeName("ufbx_vec3 *")]
        public Vec3* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
