using System;

namespace UFBX.Interop
{
    public unsafe partial struct CameraSwitcherList
    {
        [NativeTypeName("ufbx_camera_switcher **")]
        public CameraSwitcher** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
