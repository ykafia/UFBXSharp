using System;

namespace UFBX.Interop
{
    public unsafe partial struct ConstraintList
    {
        [NativeTypeName("ufbx_constraint **")]
        public Constraint** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
