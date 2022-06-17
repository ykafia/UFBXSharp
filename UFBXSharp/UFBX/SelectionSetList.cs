using System;

namespace UFBX.Interop
{
    public unsafe partial struct SelectionSetList
    {
        [NativeTypeName("ufbx_selection_set **")]
        public SelectionSet** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
