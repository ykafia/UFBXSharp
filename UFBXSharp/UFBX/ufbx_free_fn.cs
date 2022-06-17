using System;
using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ufbx_free_fn(void* user, void* ptr, [NativeTypeName("size_t")] UIntPtr size);
}
