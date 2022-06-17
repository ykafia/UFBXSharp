using System;
using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public unsafe partial struct NurbsSurface
    {
        [NativeTypeName("union ufbx_nurbs_surface::(anonymous at ./ufbx/ufbx.h:1103:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_nurbs_basis")]
        public NurbsBasis basis_u;

        [NativeTypeName("ufbx_nurbs_basis")]
        public NurbsBasis basis_v;

        [NativeTypeName("size_t")]
        public UIntPtr num_control_points_u;

        [NativeTypeName("size_t")]
        public UIntPtr num_control_points_v;

        [NativeTypeName("ufbx_vec4_list")]
        public Vec4List control_points;

        [NativeTypeName("int32_t")]
        public int span_subdivision_u;

        [NativeTypeName("int32_t")]
        public int span_subdivision_v;

        [NativeTypeName("_Bool")]
        public bool flip_normals;

        [NativeTypeName("ufbx_material *")]
        public Material* material;

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
            [NativeTypeName("struct ufbx_nurbs_surface::(anonymous at ./ufbx/ufbx.h:1103:32)")]
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
