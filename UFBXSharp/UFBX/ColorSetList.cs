using System;

namespace UFBX.Interop
{
    public unsafe partial struct ColorSetList
    {
        [NativeTypeName("ufbx_color_set *")]
        public ColorSet* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
