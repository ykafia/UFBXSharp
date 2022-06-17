using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public partial struct Camera
    {
        [NativeTypeName("union ufbx_camera::(anonymous at ./ufbx/ufbx.h:946:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("_Bool")]
        public bool resolution_is_pixels;

        [NativeTypeName("ufbx_vec2")]
        public Vec2 resolution;

        [NativeTypeName("ufbx_vec2")]
        public Vec2 field_of_view_deg;

        [NativeTypeName("ufbx_vec2")]
        public Vec2 field_of_view_tan;

        [NativeTypeName("ufbx_aspect_mode")]
        public AspectMode aspect_mode;

        [NativeTypeName("ufbx_aperture_mode")]
        public ApertureMode aperture_mode;

        [NativeTypeName("ufbx_gate_fit")]
        public GateFit gate_fit;

        [NativeTypeName("ufbx_aperture_format")]
        public ApertureFormat aperture_format;

        [NativeTypeName("ufbx_real")]
        public Real focal_length_mm;

        [NativeTypeName("ufbx_vec2")]
        public Vec2 film_size_inch;

        [NativeTypeName("ufbx_vec2")]
        public Vec2 aperture_size_inch;

        [NativeTypeName("ufbx_real")]
        public Real squeeze_ratio;

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
            [NativeTypeName("struct ufbx_camera::(anonymous at ./ufbx/ufbx.h:946:32)")]
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
