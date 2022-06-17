using System;

namespace UFBX.Interop
{
    public unsafe partial struct StereoCameraList
    {
        [NativeTypeName("ufbx_stereo_camera **")]
        public StereoCamera** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
