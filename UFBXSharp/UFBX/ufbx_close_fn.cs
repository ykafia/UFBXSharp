using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ufbx_close_fn(void* user);
}
