using System;

namespace UFBX.Interop
{
    public unsafe partial struct BlendChannelList
    {
        [NativeTypeName("ufbx_blend_channel **")]
        public BlendChannel** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
