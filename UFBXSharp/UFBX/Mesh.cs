using System;
using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public unsafe partial struct Mesh
    {
        [NativeTypeName("union ufbx_mesh::(anonymous at ./ufbx/ufbx.h:730:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("size_t")]
        public UIntPtr num_vertices;

        [NativeTypeName("size_t")]
        public UIntPtr num_indices;

        [NativeTypeName("size_t")]
        public UIntPtr num_triangles;

        [NativeTypeName("size_t")]
        public UIntPtr num_faces;

        [NativeTypeName("ufbx_face *")]
        public Face* faces;

        [NativeTypeName("_Bool *")]
        public bool* face_smoothing;

        [NativeTypeName("int32_t *")]
        public int* face_material;

        [NativeTypeName("size_t")]
        public UIntPtr max_face_triangles;

        [NativeTypeName("size_t")]
        public UIntPtr num_bad_faces;

        [NativeTypeName("size_t")]
        public UIntPtr num_edges;

        [NativeTypeName("ufbx_edge *")]
        public Edge* edges;

        [NativeTypeName("_Bool *")]
        public bool* edge_smoothing;

        [NativeTypeName("ufbx_real *")]
        public Real* edge_crease;

        [NativeTypeName("int32_t *")]
        public int* vertex_indices;

        [NativeTypeName("ufbx_vec3 *")]
        public Vec3* vertices;

        [NativeTypeName("int32_t *")]
        public int* vertex_first_index;

        [NativeTypeName("ufbx_vertex_vec3")]
        public VertexVec3 vertex_position;

        [NativeTypeName("ufbx_vertex_vec3")]
        public VertexVec3 vertex_normal;

        [NativeTypeName("ufbx_vertex_vec2")]
        public VertexVec2 vertex_uv;

        [NativeTypeName("ufbx_vertex_vec3")]
        public VertexVec3 vertex_tangent;

        [NativeTypeName("ufbx_vertex_vec3")]
        public VertexVec3 vertex_bitangent;

        [NativeTypeName("ufbx_vertex_vec4")]
        public VertexVec4 vertex_color;

        [NativeTypeName("ufbx_vertex_real")]
        public VertexReal vertex_crease;

        [NativeTypeName("ufbx_uv_set_list")]
        public UvSetList uv_sets;

        [NativeTypeName("ufbx_color_set_list")]
        public ColorSetList color_sets;

        [NativeTypeName("ufbx_mesh_material_list")]
        public MeshMaterialList materials;

        [NativeTypeName("_Bool")]
        public bool skinned_is_local;

        [NativeTypeName("ufbx_vertex_vec3")]
        public VertexVec3 skinned_position;

        [NativeTypeName("ufbx_vertex_vec3")]
        public VertexVec3 skinned_normal;

        [NativeTypeName("ufbx_skin_deformer_list")]
        public SkinDeformerList skin_deformers;

        [NativeTypeName("ufbx_blend_deformer_list")]
        public BlendDeformerList blend_deformers;

        [NativeTypeName("ufbx_cache_deformer_list")]
        public CacheDeformerList cache_deformers;

        [NativeTypeName("ufbx_element_list")]
        public ElementList all_deformers;

        [NativeTypeName("int32_t")]
        public int subdivision_preview_levels;

        [NativeTypeName("int32_t")]
        public int subdivision_render_levels;

        [NativeTypeName("ufbx_subdivision_display_mode")]
        public SubdivisionDisplayMode subdivision_display_mode;

        [NativeTypeName("ufbx_subdivision_boundary")]
        public SubdivisionBoundary subdivision_boundary;

        [NativeTypeName("ufbx_subdivision_boundary")]
        public SubdivisionBoundary subdivision_uv_boundary;

        [NativeTypeName("_Bool")]
        public bool subdivision_evaluated;

        [NativeTypeName("_Bool")]
        public bool from_tessellated_nurbs;

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

        public ref NodeList instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
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
            [NativeTypeName("struct ufbx_mesh::(anonymous at ./ufbx/ufbx.h:730:32)")]
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

                [NativeTypeName("ufbx_node_list")]
                public NodeList instances;
            }
        }
    }
}
