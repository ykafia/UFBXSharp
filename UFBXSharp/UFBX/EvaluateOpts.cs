using System;

namespace UFBX.Interop
{
    public unsafe partial struct EvaluateOpts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        [NativeTypeName("ufbx_allocator")]
        public Allocator temp_allocator;

        [NativeTypeName("ufbx_allocator")]
        public Allocator result_allocator;

        [NativeTypeName("_Bool")]
        public bool evaluate_skinning;

        [NativeTypeName("_Bool")]
        public bool evaluate_caches;

        [NativeTypeName("_Bool")]
        public bool load_external_files;

        [NativeTypeName("ufbx_open_file_fn *")]
        public IntPtr open_file_fn;

        public void* open_file_user;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }
}
