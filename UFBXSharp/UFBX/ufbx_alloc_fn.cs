using System;
using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* ufbx_alloc_fn(void* user, [NativeTypeName("size_t")] UIntPtr size);
}
