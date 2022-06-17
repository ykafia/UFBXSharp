using System;

namespace UFBX.Interop
{
    public unsafe partial struct MetadataObjectList
    {
        [NativeTypeName("ufbx_metadata_object **")]
        public MetadataObject** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
