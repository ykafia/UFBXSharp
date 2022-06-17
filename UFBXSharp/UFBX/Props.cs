using System;

namespace UFBX.Interop
{
    public unsafe partial struct Props
    {
        [NativeTypeName("ufbx_prop *")]
        public Prop* props;

        [NativeTypeName("size_t")]
        public UIntPtr num_props;

        [NativeTypeName("size_t")]
        public UIntPtr num_animated;

        [NativeTypeName("ufbx_props *")]
        public Props* defaults;
    }
}
