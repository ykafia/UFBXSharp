using System;

namespace UFBX.Interop
{
    public unsafe partial struct CameraList
    {
        [NativeTypeName("ufbx_camera **")]
        public Camera** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
