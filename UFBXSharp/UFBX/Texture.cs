using System;
using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public unsafe partial struct Texture
    {
        [NativeTypeName("union ufbx_texture::(anonymous at ./ufbx/ufbx.h:1814:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_texture_type")]
        public TextureType type;

        [NativeTypeName("ufbx_string")]
        public String filename;

        [NativeTypeName("ufbx_string")]
        public String absolute_filename;

        [NativeTypeName("ufbx_string")]
        public String relative_filename;

        [NativeTypeName("const void *")]
        public void* content;

        [NativeTypeName("size_t")]
        public UIntPtr content_size;

        [NativeTypeName("ufbx_video *")]
        public Video* video;

        [NativeTypeName("ufbx_texture_layer_list")]
        public TextureLayerList layers;

        [NativeTypeName("ufbx_string")]
        public String uv_set;

        [NativeTypeName("ufbx_wrap_mode")]
        public WrapMode wrap_u;

        [NativeTypeName("ufbx_wrap_mode")]
        public WrapMode wrap_v;

        public ufbx_transform transform;

        public ufbx_matrix texture_to_uv;

        public ufbx_matrix uv_to_texture;

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
            [NativeTypeName("struct ufbx_texture::(anonymous at ./ufbx/ufbx.h:1814:32)")]
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
