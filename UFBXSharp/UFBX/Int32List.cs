using System;

namespace UFBX.Interop
{
    public unsafe partial struct Int32List
    {
        [NativeTypeName("int32_t *")]
        public int* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
