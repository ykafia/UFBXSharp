using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public partial struct Vec3
    {
        [NativeTypeName("union ufbx_vec3::(anonymous at ./ufbx/ufbx.h:74:2)")]
        public _Anonymous_e__Union Anonymous;

        public ref Real x
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->x;
                }
            }
        }

        public ref Real y
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->y;
                }
            }
        }

        public ref Real z
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->z;
                }
            }
        }

        public ref _Anonymous_e__Union._v_e__FixedBuffer v
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->v;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct ufbx_vec3::(anonymous at ./ufbx/ufbx.h:75:3)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_real[3]")]
            public _v_e__FixedBuffer v;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_real")]
                public Real x;

                [NativeTypeName("ufbx_real")]
                public Real y;

                [NativeTypeName("ufbx_real")]
                public Real z;
            }

            public partial struct _v_e__FixedBuffer
            {
                public Real e0;
                public Real e1;
                public Real e2;

                public unsafe ref Real this[int index]
                {
                    get
                    {
                        fixed (Real* pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }
    }
}
