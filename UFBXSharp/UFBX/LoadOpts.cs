using System;

namespace UFBX.Interop
{
    public unsafe partial struct LoadOpts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        [NativeTypeName("ufbx_allocator")]
        public Allocator temp_allocator;

        [NativeTypeName("ufbx_allocator")]
        public Allocator result_allocator;

        [NativeTypeName("_Bool")]
        public bool ignore_geometry;

        [NativeTypeName("_Bool")]
        public bool ignore_animation;

        [NativeTypeName("_Bool")]
        public bool ignore_embedded;

        [NativeTypeName("_Bool")]
        public bool evaluate_skinning;

        [NativeTypeName("_Bool")]
        public bool evaluate_caches;

        [NativeTypeName("_Bool")]
        public bool load_external_files;

        [NativeTypeName("_Bool")]
        public bool skip_skin_vertices;

        [NativeTypeName("_Bool")]
        public bool disable_quirks;

        [NativeTypeName("_Bool")]
        public bool strict;

        [NativeTypeName("_Bool")]
        public bool allow_out_of_bounds_vertex_indices;

        [NativeTypeName("_Bool")]
        public bool connect_broken_elements;

        [NativeTypeName("_Bool")]
        public bool allow_nodes_out_of_root;

        [NativeTypeName("_Bool")]
        public bool allow_null_material;

        [NativeTypeName("uint64_t")]
        public ulong file_size_estimate;

        [NativeTypeName("size_t")]
        public UIntPtr read_buffer_size;

        [NativeTypeName("ufbx_string")]
        public String filename;

        [NativeTypeName("ufbx_progress_fn *")]
        public IntPtr progress_fn;

        public void* progress_user;

        [NativeTypeName("uint64_t")]
        public ulong progress_interval_hint;

        [NativeTypeName("ufbx_open_file_fn *")]
        public IntPtr open_file_fn;

        public void* open_file_user;

        [NativeTypeName("ufbx_coordinate_axes")]
        public CoordinateAxes target_axes;

        [NativeTypeName("ufbx_real")]
        public Real target_unit_meters;

        [NativeTypeName("_Bool")]
        public bool no_prop_unit_scaling;

        [NativeTypeName("_Bool")]
        public bool no_anim_curve_unit_scaling;

        [NativeTypeName("_Bool")]
        public bool use_root_transform;

        public ufbx_transform root_transform;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }
}
