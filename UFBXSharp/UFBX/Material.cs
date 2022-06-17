using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public unsafe partial struct Material
    {
        [NativeTypeName("union ufbx_material::(anonymous at ./ufbx/ufbx.h:1718:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_material_fbx_maps")]
        public MaterialFbxMaps fbx;

        [NativeTypeName("ufbx_material_pbr_maps")]
        public MaterialPbrMaps pbr;

        [NativeTypeName("ufbx_shader_type")]
        public ShaderType shader_type;

        [NativeTypeName("ufbx_shader *")]
        public Shader* shader;

        [NativeTypeName("ufbx_string")]
        public String shading_model_name;

        [NativeTypeName("ufbx_material_texture_list")]
        public MaterialTextureList textures;

        public ref Element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref String name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref Props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ufbx_element")]
            public Element element;

            [FieldOffset(0)]
            [NativeTypeName("struct ufbx_material::(anonymous at ./ufbx/ufbx.h:1718:32)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_string")]
                public String name;

                [NativeTypeName("ufbx_props")]
                public Props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }
}
