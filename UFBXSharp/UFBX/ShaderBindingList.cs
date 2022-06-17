using System;

namespace UFBX.Interop
{
    public unsafe partial struct ShaderBindingList
    {
        [NativeTypeName("ufbx_shader_binding **")]
        public ShaderBinding** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
