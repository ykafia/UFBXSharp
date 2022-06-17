using System;
using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("_Bool")]
    public unsafe delegate bool ufbx_skip_fn(void* user, [NativeTypeName("size_t")] UIntPtr size);
}
