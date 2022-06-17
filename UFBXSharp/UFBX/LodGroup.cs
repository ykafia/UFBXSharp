using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public partial struct LodGroup
    {
        [NativeTypeName("union ufbx_lod_group::(anonymous at ./ufbx/ufbx.h:1220:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("_Bool")]
        public bool relative_distances;

        [NativeTypeName("ufbx_lod_level_list")]
        public LodLevelList lod_levels;

        [NativeTypeName("_Bool")]
        public bool ignore_parent_transform;

        [NativeTypeName("_Bool")]
        public bool use_distance_limit;

        [NativeTypeName("ufbx_real")]
        public Real distance_limit_min;

        [NativeTypeName("ufbx_real")]
        public Real distance_limit_max;

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
            [NativeTypeName("struct ufbx_lod_group::(anonymous at ./ufbx/ufbx.h:1220:32)")]
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
