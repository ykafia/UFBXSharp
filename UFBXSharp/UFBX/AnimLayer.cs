using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public unsafe partial struct AnimLayer
    {
        [NativeTypeName("union ufbx_anim_layer::(anonymous at ./ufbx/ufbx.h:1975:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_real")]
        public Real weight;

        [NativeTypeName("_Bool")]
        public bool weight_is_animated;

        [NativeTypeName("_Bool")]
        public bool blended;

        [NativeTypeName("_Bool")]
        public bool additive;

        [NativeTypeName("_Bool")]
        public bool compose_rotation;

        [NativeTypeName("_Bool")]
        public bool compose_scale;

        [NativeTypeName("ufbx_anim_value_list")]
        public AnimValueList anim_values;

        [NativeTypeName("ufbx_anim_prop_list")]
        public AnimPropList anim_props;

        [NativeTypeName("ufbx_anim")]
        public Anim anim;

        [NativeTypeName("uint32_t")]
        public uint min_element_id;

        [NativeTypeName("uint32_t")]
        public uint max_element_id;

        [NativeTypeName("uint32_t[4]")]
        public fixed uint element_id_bitmask[4];

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
            [NativeTypeName("struct ufbx_anim_layer::(anonymous at ./ufbx/ufbx.h:1975:32)")]
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
