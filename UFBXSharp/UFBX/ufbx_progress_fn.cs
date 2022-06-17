using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("_Bool")]
    public unsafe delegate bool ufbx_progress_fn(void* user, [NativeTypeName("const ufbx_progress *")] Progress* progress);
}
