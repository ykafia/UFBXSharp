using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public partial struct ufbx_matrix
    {
        [NativeTypeName("union ufbx_matrix::(anonymous at ./ufbx/ufbx.h:127:2)")]
        public _Anonymous_e__Union Anonymous;

        public ref Real m00
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m00;
                }
            }
        }

        public ref Real m10
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m10;
                }
            }
        }

        public ref Real m20
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m20;
                }
            }
        }

        public ref Real m01
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m01;
                }
            }
        }

        public ref Real m11
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m11;
                }
            }
        }

        public ref Real m21
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m21;
                }
            }
        }

        public ref Real m02
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m02;
                }
            }
        }

        public ref Real m12
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m12;
                }
            }
        }

        public ref Real m22
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m22;
                }
            }
        }

        public ref Real m03
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m03;
                }
            }
        }

        public ref Real m13
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m13;
                }
            }
        }

        public ref Real m23
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m23;
                }
            }
        }

        public ref _Anonymous_e__Union._cols_e__FixedBuffer cols
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->cols;
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
            [NativeTypeName("struct ufbx_matrix::(anonymous at ./ufbx/ufbx.h:128:3)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_vec3[4]")]
            public _cols_e__FixedBuffer cols;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_real[12]")]
            public _v_e__FixedBuffer v;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_real")]
                public Real m00;

                [NativeTypeName("ufbx_real")]
                public Real m10;

                [NativeTypeName("ufbx_real")]
                public Real m20;

                [NativeTypeName("ufbx_real")]
                public Real m01;

                [NativeTypeName("ufbx_real")]
                public Real m11;

                [NativeTypeName("ufbx_real")]
                public Real m21;

                [NativeTypeName("ufbx_real")]
                public Real m02;

                [NativeTypeName("ufbx_real")]
                public Real m12;

                [NativeTypeName("ufbx_real")]
                public Real m22;

                [NativeTypeName("ufbx_real")]
                public Real m03;

                [NativeTypeName("ufbx_real")]
                public Real m13;

                [NativeTypeName("ufbx_real")]
                public Real m23;
            }

            public partial struct _cols_e__FixedBuffer
            {
                public Vec3 e0;
                public Vec3 e1;
                public Vec3 e2;
                public Vec3 e3;

                public unsafe ref Vec3 this[int index]
                {
                    get
                    {
                        fixed (Vec3* pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }

            public partial struct _v_e__FixedBuffer
            {
                public Real e0;
                public Real e1;
                public Real e2;
                public Real e3;
                public Real e4;
                public Real e5;
                public Real e6;
                public Real e7;
                public Real e8;
                public Real e9;
                public Real e10;
                public Real e11;

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
