using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public partial struct MaterialPbrMaps
    {
        [NativeTypeName("union ufbx_material_pbr_maps::(anonymous at ./ufbx/ufbx.h:1657:2)")]
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

        public ref MaterialMap base_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->base_factor;
                }
            }
        }

        public ref MaterialMap base_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->base_color;
                }
            }
        }

        public ref MaterialMap roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->roughness;
                }
            }
        }

        public ref MaterialMap metallic
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->metallic;
                }
            }
        }

        public ref MaterialMap diffuse_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->diffuse_roughness;
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

        public ref MaterialMap specular_ior
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_ior;
                }
            }
        }

        public ref MaterialMap specular_anisotropy
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_anisotropy;
                }
            }
        }

        public ref MaterialMap specular_rotation
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_rotation;
                }
            }
        }

        public ref MaterialMap transmission_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_factor;
                }
            }
        }

        public ref MaterialMap transmission_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_color;
                }
            }
        }

        public ref MaterialMap transmission_depth
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_depth;
                }
            }
        }

        public ref MaterialMap transmission_scatter
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_scatter;
                }
            }
        }

        public ref MaterialMap transmission_scatter_anisotropy
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_scatter_anisotropy;
                }
            }
        }

        public ref MaterialMap transmission_dispersion
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_dispersion;
                }
            }
        }

        public ref MaterialMap transmission_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_roughness;
                }
            }
        }

        public ref MaterialMap transmission_priority
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_priority;
                }
            }
        }

        public ref MaterialMap transmission_enable_in_aov
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_enable_in_aov;
                }
            }
        }

        public ref MaterialMap subsurface_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_factor;
                }
            }
        }

        public ref MaterialMap subsurface_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_color;
                }
            }
        }

        public ref MaterialMap subsurface_radius
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_radius;
                }
            }
        }

        public ref MaterialMap subsurface_scale
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_scale;
                }
            }
        }

        public ref MaterialMap subsurface_anisotropy
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_anisotropy;
                }
            }
        }

        public ref MaterialMap subsurface_type
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_type;
                }
            }
        }

        public ref MaterialMap sheen_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->sheen_factor;
                }
            }
        }

        public ref MaterialMap sheen_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->sheen_color;
                }
            }
        }

        public ref MaterialMap sheen_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->sheen_roughness;
                }
            }
        }

        public ref MaterialMap coat_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_factor;
                }
            }
        }

        public ref MaterialMap coat_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_color;
                }
            }
        }

        public ref MaterialMap coat_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_roughness;
                }
            }
        }

        public ref MaterialMap coat_ior
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_ior;
                }
            }
        }

        public ref MaterialMap coat_anisotropy
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_anisotropy;
                }
            }
        }

        public ref MaterialMap coat_rotation
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_rotation;
                }
            }
        }

        public ref MaterialMap coat_normal
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_normal;
                }
            }
        }

        public ref MaterialMap thin_film_thickness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->thin_film_thickness;
                }
            }
        }

        public ref MaterialMap thin_film_ior
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->thin_film_ior;
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

        public ref MaterialMap opacity
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->opacity;
                }
            }
        }

        public ref MaterialMap indirect_diffuse
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->indirect_diffuse;
                }
            }
        }

        public ref MaterialMap indirect_specular
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->indirect_specular;
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

        public ref MaterialMap tangent_map
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->tangent_map;
                }
            }
        }

        public ref MaterialMap matte_enabled
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->matte_enabled;
                }
            }
        }

        public ref MaterialMap matte_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->matte_factor;
                }
            }
        }

        public ref MaterialMap matte_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->matte_color;
                }
            }
        }

        public ref MaterialMap thin_walled
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->thin_walled;
                }
            }
        }

        public ref MaterialMap caustics
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->caustics;
                }
            }
        }

        public ref MaterialMap exit_to_background
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->exit_to_background;
                }
            }
        }

        public ref MaterialMap internal_reflections
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->internal_reflections;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ufbx_material_map[51]")]
            public _maps_e__FixedBuffer maps;

            [FieldOffset(0)]
            [NativeTypeName("struct ufbx_material_pbr_maps::(anonymous at ./ufbx/ufbx.h:1659:3)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_material_map")]
                public MaterialMap base_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap base_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap roughness;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap metallic;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap diffuse_roughness;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap specular_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap specular_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap specular_ior;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap specular_anisotropy;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap specular_rotation;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap transmission_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap transmission_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap transmission_depth;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap transmission_scatter;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap transmission_scatter_anisotropy;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap transmission_dispersion;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap transmission_roughness;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap transmission_priority;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap transmission_enable_in_aov;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap subsurface_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap subsurface_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap subsurface_radius;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap subsurface_scale;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap subsurface_anisotropy;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap subsurface_type;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap sheen_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap sheen_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap sheen_roughness;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap coat_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap coat_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap coat_roughness;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap coat_ior;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap coat_anisotropy;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap coat_rotation;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap coat_normal;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap thin_film_thickness;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap thin_film_ior;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap emission_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap emission_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap opacity;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap indirect_diffuse;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap indirect_specular;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap normal_map;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap tangent_map;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap matte_enabled;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap matte_factor;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap matte_color;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap thin_walled;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap caustics;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap exit_to_background;

                [NativeTypeName("ufbx_material_map")]
                public MaterialMap internal_reflections;
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
                public MaterialMap e20;
                public MaterialMap e21;
                public MaterialMap e22;
                public MaterialMap e23;
                public MaterialMap e24;
                public MaterialMap e25;
                public MaterialMap e26;
                public MaterialMap e27;
                public MaterialMap e28;
                public MaterialMap e29;
                public MaterialMap e30;
                public MaterialMap e31;
                public MaterialMap e32;
                public MaterialMap e33;
                public MaterialMap e34;
                public MaterialMap e35;
                public MaterialMap e36;
                public MaterialMap e37;
                public MaterialMap e38;
                public MaterialMap e39;
                public MaterialMap e40;
                public MaterialMap e41;
                public MaterialMap e42;
                public MaterialMap e43;
                public MaterialMap e44;
                public MaterialMap e45;
                public MaterialMap e46;
                public MaterialMap e47;
                public MaterialMap e48;
                public MaterialMap e49;
                public MaterialMap e50;

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
