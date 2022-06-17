using System;

namespace UFBX.Interop
{
    public unsafe partial struct InflateInput
    {
        [NativeTypeName("size_t")]
        public UIntPtr total_size;

        [NativeTypeName("const void *")]
        public void* data;

        [NativeTypeName("size_t")]
        public UIntPtr data_size;

        public void* buffer;

        [NativeTypeName("size_t")]
        public UIntPtr buffer_size;

        [NativeTypeName("ufbx_read_fn *")]
        public IntPtr read_fn;

        public void* read_user;

        [NativeTypeName("ufbx_progress_fn *")]
        public IntPtr progress_fn;

        public void* progress_user;

        [NativeTypeName("uint64_t")]
        public ulong progress_interval_hint;

        [NativeTypeName("uint64_t")]
        public ulong progress_size_before;

        [NativeTypeName("uint64_t")]
        public ulong progress_size_after;
    }
}
