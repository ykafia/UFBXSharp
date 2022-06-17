using System;
using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public unsafe partial struct SkinCluster
    {
        [NativeTypeName("union ufbx_skin_cluster::(anonymous at ./ufbx/ufbx.h:1317:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_node *")]
        public Node* bone_node;

        public ufbx_matrix geometry_to_bone;

        public ufbx_matrix mesh_node_to_bone;

        public ufbx_matrix bind_to_world;

        public ufbx_matrix geometry_to_world;

        public ufbx_transform geometry_to_world_transform;

        [NativeTypeName("size_t")]
        public UIntPtr num_weights;

        [NativeTypeName("int32_t *")]
        public int* vertices;

        [NativeTypeName("ufbx_real *")]
        public Real* weights;

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
            [NativeTypeName("struct ufbx_skin_cluster::(anonymous at ./ufbx/ufbx.h:1317:32)")]
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
