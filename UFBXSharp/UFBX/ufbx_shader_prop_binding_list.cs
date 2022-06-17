using System;

namespace UFBX.Interop
{
    public unsafe partial struct ufbx_shader_prop_binding_list
    {
        [NativeTypeName("ufbx_shader_prop_binding *")]
        public ShaderPropBinding* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
