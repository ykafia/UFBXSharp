using System;

namespace UFBX.Interop
{
    public unsafe partial struct ElementList
    {
        [NativeTypeName("ufbx_element **")]
        public Element** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
