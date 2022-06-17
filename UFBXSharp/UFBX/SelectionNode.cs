using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public unsafe partial struct SelectionNode
    {
        [NativeTypeName("union ufbx_selection_node::(anonymous at ./ufbx/ufbx.h:2089:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_node *")]
        public Node* target_node;

        [NativeTypeName("ufbx_mesh *")]
        public Mesh* target_mesh;

        [NativeTypeName("_Bool")]
        public bool include_node;

        [NativeTypeName("ufbx_int32_list")]
        public Int32List vertices;

        [NativeTypeName("ufbx_int32_list")]
        public Int32List edges;

        [NativeTypeName("ufbx_int32_list")]
        public Int32List faces;

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
            [NativeTypeName("struct ufbx_selection_node::(anonymous at ./ufbx/ufbx.h:2089:32)")]
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
