using System;

namespace UFBX.Interop
{
    public unsafe partial struct NodeList
    {
        [NativeTypeName("ufbx_node **")]
        public Node** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
