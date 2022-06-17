using System;
using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("_Bool")]
    public unsafe delegate bool ufbx_open_file_fn(void* user, [NativeTypeName("ufbx_stream *")] Stream* stream, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("size_t")] UIntPtr path_len);
}
