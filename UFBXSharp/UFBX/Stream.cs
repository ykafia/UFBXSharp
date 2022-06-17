using System;

namespace UFBX.Interop
{
    public unsafe partial struct Stream
    {
        public void* user;

        [NativeTypeName("ufbx_read_fn *")]
        public IntPtr read_fn;

        [NativeTypeName("ufbx_skip_fn *")]
        public IntPtr skip_fn;

        [NativeTypeName("ufbx_close_fn *")]
        public IntPtr close_fn;
    }
}
