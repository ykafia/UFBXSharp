using System;

namespace UFBX.Interop
{
    public unsafe partial struct NameElementList
    {
        [NativeTypeName("ufbx_name_element *")]
        public NameElement* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
