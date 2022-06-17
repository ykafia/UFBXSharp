using System;
using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* ufbx_realloc_fn(void* user, void* old_ptr, [NativeTypeName("size_t")] UIntPtr old_size, [NativeTypeName("size_t")] UIntPtr new_size);
}
