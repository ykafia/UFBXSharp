using System;

namespace UFBX.Interop
{
    public unsafe partial struct ConstPropOverrideList
    {
        [NativeTypeName("const ufbx_prop_override *")]
        public PropOverride* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
