using System;
using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("size_t")]
    public unsafe delegate UIntPtr ufbx_read_fn(void* user, void* data, [NativeTypeName("size_t")] UIntPtr size);
}
