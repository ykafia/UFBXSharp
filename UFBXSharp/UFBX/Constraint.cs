using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public unsafe partial struct Constraint
    {
        [NativeTypeName("union ufbx_constraint::(anonymous at ./ufbx/ufbx.h:2156:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_constraint_type")]
        public ConstraintType type;

        [NativeTypeName("ufbx_string")]
        public String type_name;

        [NativeTypeName("ufbx_node *")]
        public Node* node;

        [NativeTypeName("ufbx_constraint_target_list")]
        public ConstraintTargetList targets;

        [NativeTypeName("ufbx_real")]
        public Real weight;

        [NativeTypeName("_Bool")]
        public bool active;

        [NativeTypeName("_Bool[3]")]
        public fixed bool constrain_translation[3];

        [NativeTypeName("_Bool[3]")]
        public fixed bool constrain_rotation[3];

        [NativeTypeName("_Bool[3]")]
        public fixed bool constrain_scale[3];

        public ufbx_transform transform_offset;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 aim_vector;

        [NativeTypeName("ufbx_constraint_aim_up_type")]
        public ConstraintAimUpType aim_up_type;

        [NativeTypeName("ufbx_node *")]
        public Node* aim_up_node;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 aim_up_vector;

        [NativeTypeName("ufbx_node *")]
        public Node* ik_effector;

        [NativeTypeName("ufbx_node *")]
        public Node* ik_end_node;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 ik_pole_vector;

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
            [NativeTypeName("struct ufbx_constraint::(anonymous at ./ufbx/ufbx.h:2156:32)")]
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
