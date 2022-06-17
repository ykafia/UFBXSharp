using System;

namespace UFBX.Interop
{
    public unsafe partial struct GeometryCacheOpts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        [NativeTypeName("ufbx_allocator")]
        public Allocator temp_allocator;

        [NativeTypeName("ufbx_allocator")]
        public Allocator result_allocator;

        [NativeTypeName("ufbx_open_file_fn *")]
        public IntPtr open_file_fn;

        public void* open_file_user;

        public double frames_per_second;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }
}
