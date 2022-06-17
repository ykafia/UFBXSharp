using System;

namespace UFBX.Interop
{
    public partial struct Metadata
    {
        [NativeTypeName("_Bool")]
        public bool ascii;

        [NativeTypeName("uint32_t")]
        public uint version;

        [NativeTypeName("ufbx_string")]
        public String creator;

        [NativeTypeName("_Bool")]
        public bool big_endian;

        [NativeTypeName("ufbx_string")]
        public String filename;

        [NativeTypeName("ufbx_string")]
        public String relative_root;

        [NativeTypeName("ufbx_exporter")]
        public Exporter exporter;

        [NativeTypeName("uint32_t")]
        public uint exporter_version;

        [NativeTypeName("ufbx_props")]
        public Props scene_props;

        [NativeTypeName("ufbx_application")]
        public Application original_application;

        [NativeTypeName("ufbx_application")]
        public Application latest_application;

        [NativeTypeName("_Bool")]
        public bool geometry_ignored;

        [NativeTypeName("_Bool")]
        public bool animation_ignored;

        [NativeTypeName("_Bool")]
        public bool embedded_ignored;

        [NativeTypeName("size_t")]
        public UIntPtr max_face_triangles;

        [NativeTypeName("size_t")]
        public UIntPtr result_memory_used;

        [NativeTypeName("size_t")]
        public UIntPtr temp_memory_used;

        [NativeTypeName("size_t")]
        public UIntPtr result_allocs;

        [NativeTypeName("size_t")]
        public UIntPtr temp_allocs;

        [NativeTypeName("size_t")]
        public UIntPtr element_buffer_size;

        [NativeTypeName("ufbx_real")]
        public Real bone_prop_size_unit;

        [NativeTypeName("_Bool")]
        public bool bone_prop_limb_length_relative;

        public double ktime_to_sec;
    }
}
