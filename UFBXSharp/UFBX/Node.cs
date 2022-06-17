using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public unsafe partial struct Node
    {
        [NativeTypeName("union ufbx_node::(anonymous at ./ufbx/ufbx.h:468:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_node *")]
        public Node* parent;

        [NativeTypeName("ufbx_node_list")]
        public NodeList children;

        [NativeTypeName("ufbx_mesh *")]
        public Mesh* mesh;

        [NativeTypeName("ufbx_light *")]
        public Light* light;

        [NativeTypeName("ufbx_camera *")]
        public Camera* camera;

        [NativeTypeName("ufbx_bone *")]
        public Bone* bone;

        [NativeTypeName("ufbx_element *")]
        public Element* attrib;

        [NativeTypeName("ufbx_element_type")]
        public ElementType attrib_type;

        [NativeTypeName("ufbx_element_list")]
        public ElementList all_attribs;

        [NativeTypeName("ufbx_inherit_type")]
        public InheritType inherit_type;

        public ufbx_transform local_transform;

        public ufbx_transform geometry_transform;

        public ufbx_rotation_order rotation_order;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 euler_rotation;

        public ufbx_transform world_transform;

        public ufbx_matrix node_to_parent;

        public ufbx_matrix node_to_world;

        public ufbx_matrix geometry_to_node;

        public ufbx_matrix geometry_to_world;

        [NativeTypeName("_Bool")]
        public bool visible;

        [NativeTypeName("_Bool")]
        public bool is_root;

        [NativeTypeName("uint32_t")]
        public uint node_depth;

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
            [NativeTypeName("struct ufbx_node::(anonymous at ./ufbx/ufbx.h:468:32)")]
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
