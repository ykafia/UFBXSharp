using System;

namespace UFBX.Interop
{
    public unsafe partial struct GeometryCacheDataOpts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        [NativeTypeName("ufbx_open_file_fn *")]
        public IntPtr open_file_fn;

        public void* open_file_user;

        [NativeTypeName("_Bool")]
        public bool additive;

        [NativeTypeName("_Bool")]
        public bool use_weight;

        [NativeTypeName("ufbx_real")]
        public Real weight;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }
}
