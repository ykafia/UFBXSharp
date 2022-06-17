using System;

namespace UFBX.Interop
{
    public unsafe partial struct String
    {
        [NativeTypeName("const char *")]
        public sbyte* data;

        [NativeTypeName("size_t")]
        public UIntPtr length;
    }
}
