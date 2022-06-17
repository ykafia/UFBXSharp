using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public partial struct Prop
    {
        [NativeTypeName("ufbx_string")]
        public String name;

        [NativeTypeName("uint32_t")]
        public uint internal_key;

        public ufbx_prop_type type;

        [NativeTypeName("ufbx_prop_flags")]
        public PropFlags flags;

        [NativeTypeName("ufbx_string")]
        public String value_str;

        [NativeTypeName("int64_t")]
        public long value_int;

        [NativeTypeName("union ufbx_prop::(anonymous at ./ufbx/ufbx.h:230:2)")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._value_real_arr_e__FixedBuffer value_real_arr
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_real_arr;
                }
            }
        }

        public ref Real value_real
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_real;
                }
            }
        }

        public ref Vec2 value_vec2
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_vec2;
                }
            }
        }

        public ref Vec3 value_vec3
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_vec3;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ufbx_real[3]")]
            public _value_real_arr_e__FixedBuffer value_real_arr;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_real")]
            public Real value_real;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_vec2")]
            public Vec2 value_vec2;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_vec3")]
            public Vec3 value_vec3;

            public partial struct _value_real_arr_e__FixedBuffer
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
