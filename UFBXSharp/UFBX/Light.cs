using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public partial struct Light
    {
        [NativeTypeName("union ufbx_light::(anonymous at ./ufbx/ufbx.h:853:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 color;

        [NativeTypeName("ufbx_real")]
        public Real intensity;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 local_direction;

        [NativeTypeName("ufbx_light_type")]
        public LightType type;

        [NativeTypeName("ufbx_light_decay")]
        public LightDecay decay;

        [NativeTypeName("ufbx_light_area_shape")]
        public LightAreaShape area_shape;

        [NativeTypeName("ufbx_real")]
        public Real inner_angle;

        [NativeTypeName("ufbx_real")]
        public Real outer_angle;

        [NativeTypeName("_Bool")]
        public bool cast_light;

        [NativeTypeName("_Bool")]
        public bool cast_shadows;

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

        public ref NodeList instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
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
            [NativeTypeName("struct ufbx_light::(anonymous at ./ufbx/ufbx.h:853:32)")]
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

                [NativeTypeName("ufbx_node_list")]
                public NodeList instances;
            }
        }
    }
}
