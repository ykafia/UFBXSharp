using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public partial struct AnimValue
    {
        [NativeTypeName("union ufbx_anim_value::(anonymous at ./ufbx/ufbx.h:2000:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_vec3")]
        public Vec3 default_value;

        [NativeTypeName("ufbx_anim_curve *[3]")]
        public _curves_e__FixedBuffer curves;

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

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ufbx_element")]
            public Element element;

            [FieldOffset(0)]
            [NativeTypeName("struct ufbx_anim_value::(anonymous at ./ufbx/ufbx.h:2000:32)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_string")]
                public String name;

                [NativeTypeName("ufbx_props")]
                public Props props;
            }
        }

        public unsafe partial struct _curves_e__FixedBuffer
        {
            public AnimCurve* e0;
            public AnimCurve* e1;
            public AnimCurve* e2;

            public ref AnimCurve* this[int index]
            {
                get
                {
                    fixed (AnimCurve** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
