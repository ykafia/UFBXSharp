using System;

namespace UFBX.Interop
{
    public unsafe partial struct StringList
    {
        [NativeTypeName("ufbx_string *")]
        public String* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
