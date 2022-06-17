using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public partial struct MaterialFbxMaps
    {
        [NativeTypeName("union ufbx_material_fbx_maps::(anonymous at ./ufbx/ufbx.h:1629:2)")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._maps_e__FixedBuffer maps
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->maps;
                }
            }
        }

        public ref MaterialMap diffuse_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->diffuse_factor;
                }
            }
        }

        public ref MaterialMap diffuse_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->diffuse_color;
                }
            }
        }

        public ref MaterialMap specular_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_factor;
                }
            }
        }

        public ref MaterialMap specular_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_color;
                }
            }
        }

        public ref MaterialMap specular_exponent
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_exponent;
                }
            }
        }

        public ref MaterialMap reflection_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->reflection_factor;
                }
            }
        }

        public ref MaterialMap reflection_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->reflection_color;
                }
            }
        }

        public ref MaterialMap transparency_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transparency_factor;
                }
            }
        }

        public ref MaterialMap transparency_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transparency_color;
                }
            }
        }

        public ref MaterialMap emission_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->emission_factor;
                }
            }
        }

        public ref MaterialMap emission_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->emission_color;
                }
            }
        }

        public ref MaterialMap ambient_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->ambient_factor;
                }
            }
        }

        public ref MaterialMap ambient_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->ambient_color;
                }
            }
        }

        public ref MaterialMap normal_map
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->normal_map;
                }
            }
        }

        public ref MaterialMap bump
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->bump;
                }
            }
        }

        public ref MaterialMap bump_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->bump_factor;
                }
            }
        }

        public ref MaterialMap displacement_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->displacement_factor;
                }
            }
        }

        public ref MaterialMap displacement
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->displacement;
                }
            }
        }

        public ref MaterialMap vector_displacement_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->vector_displacement_factor;
                }
            }
        }

        public ref MaterialMap vector_displacement
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->vector_displacement;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ufbx_material_map[20]")]
            public _maps_e__FixedBuffer maps;

            [FieldOffset(0)]
            [NativeTypeName("struct ufbx_material_fbx_maps::(anonymous at ./ufbx/ufbx.h:1631:3)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_material_map")]
                public MaterialMap diffuse_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap diffuse_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap specular_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap specular_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap specular_exponent;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap reflection_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap reflection_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap transparency_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap transparency_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap emission_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap emission_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap ambient_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap ambient_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap normal_map;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap bump;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap bump_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap displacement_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap displacement;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap vector_displacement_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap vector_displacement;
            }

            public partial struct _maps_e__FixedBuffer
            {
                public MaterialMap e0;
                public MaterialMap e1;
                public MaterialMap e2;
                public MaterialMap e3;
                public MaterialMap e4;
                public MaterialMap e5;
                public MaterialMap e6;
                public MaterialMap e7;
                public MaterialMap e8;
                public MaterialMap e9;
                public MaterialMap e10;
                public MaterialMap e11;
                public MaterialMap e12;
                public MaterialMap e13;
                public MaterialMap e14;
                public MaterialMap e15;
                public MaterialMap e16;
                public MaterialMap e17;
                public MaterialMap e18;
                public MaterialMap e19;

                public unsafe ref MaterialMap this[int index]
                {
                    get
                    {
                        fixed (MaterialMap* pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }
    }
}
