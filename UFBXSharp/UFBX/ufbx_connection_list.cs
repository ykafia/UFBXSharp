using System;

namespace UFBX.Interop
{
    public unsafe partial struct ufbx_connection_list
    {
        [NativeTypeName("ufbx_connection *")]
        public Connection* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
