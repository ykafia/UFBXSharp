using System;

namespace UFBX.Interop
{
    public unsafe partial struct SelectionNodeList
    {
        [NativeTypeName("ufbx_selection_node **")]
        public SelectionNode** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
