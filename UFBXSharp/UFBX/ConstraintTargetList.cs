using System;

namespace UFBX.Interop
{
    public unsafe partial struct ConstraintTargetList
    {
        [NativeTypeName("ufbx_constraint_target *")]
        public ConstraintTarget* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
