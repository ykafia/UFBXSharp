using System;

namespace UFBX.Interop
{
    public unsafe partial struct Allocator
    {
        [NativeTypeName("ufbx_alloc_fn *")]
        public IntPtr alloc_fn;

        [NativeTypeName("ufbx_realloc_fn *")]
        public IntPtr realloc_fn;

        [NativeTypeName("ufbx_free_fn *")]
        public IntPtr free_fn;

        [NativeTypeName("ufbx_free_allocator_fn *")]
        public IntPtr free_allocator_fn;

        public void* user;

        [NativeTypeName("size_t")]
        public UIntPtr memory_limit;

        [NativeTypeName("size_t")]
        public UIntPtr allocation_limit;

        [NativeTypeName("size_t")]
        public UIntPtr huge_threshold;

        [NativeTypeName("size_t")]
        public UIntPtr max_chunk_size;
    }
}
