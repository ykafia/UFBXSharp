using System;

namespace UFBX.Interop
{
    public unsafe partial struct ShaderList
    {
        [NativeTypeName("ufbx_shader **")]
        public Shader** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
