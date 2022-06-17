using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public unsafe partial struct Scene
    {
        [NativeTypeName("ufbx_metadata")]
        public Metadata metadata;

        [NativeTypeName("ufbx_scene_settings")]
        public SceneSettings settings;

        [NativeTypeName("ufbx_node *")]
        public Node* root_node;

        [NativeTypeName("ufbx_anim")]
        public Anim anim;

        [NativeTypeName("ufbx_anim")]
        public Anim combined_anim;

        [NativeTypeName("union ufbx_scene::(anonymous at ./ufbx/ufbx.h:2395:2)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_element_list")]
        public ElementList elements;

        public ufbx_connection_list connections_src;

        public ufbx_connection_list connections_dst;

        [NativeTypeName("ufbx_name_element_list")]
        public NameElementList elements_by_name;

        public ref UnknownList unknowns
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->unknowns;
                }
            }
        }

        public ref NodeList nodes
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->nodes;
                }
            }
        }

        public ref MeshList meshes
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->meshes;
                }
            }
        }

        public ref LightList lights
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->lights;
                }
            }
        }

        public ref CameraList cameras
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->cameras;
                }
            }
        }

        public ref BoneList bones
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->bones;
                }
            }
        }

        public ref EmptyList empties
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->empties;
                }
            }
        }

        public ref LineCurveList line_curves
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->line_curves;
                }
            }
        }

        public ref NurbsCurveList nurbs_curves
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->nurbs_curves;
                }
            }
        }

        public ref NurbsSurfaceList nurbs_surfaces
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->nurbs_surfaces;
                }
            }
        }

        public ref NurbsTrimSurfaceList nurbs_trim_surfaces
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->nurbs_trim_surfaces;
                }
            }
        }

        public ref NurbsTrimBoundaryList nurbs_trim_boundaries
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->nurbs_trim_boundaries;
                }
            }
        }

        public ref ProceduralGeometryList procedural_geometries
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->procedural_geometries;
                }
            }
        }

        public ref StereoCameraList stereo_cameras
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->stereo_cameras;
                }
            }
        }

        public ref CameraSwitcherList camera_switchers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->camera_switchers;
                }
            }
        }

        public ref LodGroupList lod_groups
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->lod_groups;
                }
            }
        }

        public ref SkinDeformerList skin_deformers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->skin_deformers;
                }
            }
        }

        public ref SkinClusterList skin_clusters
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->skin_clusters;
                }
            }
        }

        public ref BlendDeformerList blend_deformers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->blend_deformers;
                }
            }
        }

        public ref BlendChannelList blend_channels
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->blend_channels;
                }
            }
        }

        public ref BlendShapeList blend_shapes
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->blend_shapes;
                }
            }
        }

        public ref CacheDeformerList cache_deformers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->cache_deformers;
                }
            }
        }

        public ref CacheFileList cache_files
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->cache_files;
                }
            }
        }

        public ref MaterialList materials
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->materials;
                }
            }
        }

        public ref TextureList textures
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->textures;
                }
            }
        }

        public ref VideoList videos
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->videos;
                }
            }
        }

        public ref ShaderList shaders
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->shaders;
                }
            }
        }

        public ref ShaderBindingList shader_bindings
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->shader_bindings;
                }
            }
        }

        public ref AnimStackList anim_stacks
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->anim_stacks;
                }
            }
        }

        public ref AnimLayerList anim_layers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->anim_layers;
                }
            }
        }

        public ref AnimValueList anim_values
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->anim_values;
                }
            }
        }

        public ref AnimCurveList anim_curves
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->anim_curves;
                }
            }
        }

        public ref DisplayLayerList display_layers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->display_layers;
                }
            }
        }

        public ref SelectionSetList selection_sets
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->selection_sets;
                }
            }
        }

        public ref SelectionNodeList selection_nodes
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->selection_nodes;
                }
            }
        }

        public ref CharacterList characters
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->characters;
                }
            }
        }

        public ref ConstraintList constraints
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->constraints;
                }
            }
        }

        public ref PoseList poses
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->poses;
                }
            }
        }

        public ref MetadataObjectList metadata_objects
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->metadata_objects;
                }
            }
        }

        public ref _Anonymous_e__Union._elements_by_type_e__FixedBuffer elements_by_type
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->elements_by_type;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct ufbx_scene::(anonymous at ./ufbx/ufbx.h:2396:3)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_element_list[39]")]
            public _elements_by_type_e__FixedBuffer elements_by_type;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_unknown_list")]
                public UnknownList unknowns;

                [NativeTypeName("ufbx_node_list")]
                public NodeList nodes;

                [NativeTypeName("ufbx_mesh_list")]
                public MeshList meshes;

                [NativeTypeName("ufbx_light_list")]
                public LightList lights;

                [NativeTypeName("ufbx_camera_list")]
                public CameraList cameras;

                [NativeTypeName("ufbx_bone_list")]
                public BoneList bones;

                [NativeTypeName("ufbx_empty_list")]
                public EmptyList empties;

                [NativeTypeName("ufbx_line_curve_list")]
                public LineCurveList line_curves;

                [NativeTypeName("ufbx_nurbs_curve_list")]
                public NurbsCurveList nurbs_curves;

                [NativeTypeName("ufbx_nurbs_surface_list")]
                public NurbsSurfaceList nurbs_surfaces;

                [NativeTypeName("ufbx_nurbs_trim_surface_list")]
                public NurbsTrimSurfaceList nurbs_trim_surfaces;

                [NativeTypeName("ufbx_nurbs_trim_boundary_list")]
                public NurbsTrimBoundaryList nurbs_trim_boundaries;

                [NativeTypeName("ufbx_procedural_geometry_list")]
                public ProceduralGeometryList procedural_geometries;

                [NativeTypeName("ufbx_stereo_camera_list")]
                public StereoCameraList stereo_cameras;

                [NativeTypeName("ufbx_camera_switcher_list")]
                public CameraSwitcherList camera_switchers;

                [NativeTypeName("ufbx_lod_group_list")]
                public LodGroupList lod_groups;

                [NativeTypeName("ufbx_skin_deformer_list")]
                public SkinDeformerList skin_deformers;

                [NativeTypeName("ufbx_skin_cluster_list")]
                public SkinClusterList skin_clusters;

                [NativeTypeName("ufbx_blend_deformer_list")]
                public BlendDeformerList blend_deformers;

                [NativeTypeName("ufbx_blend_channel_list")]
                public BlendChannelList blend_channels;

                [NativeTypeName("ufbx_blend_shape_list")]
                public BlendShapeList blend_shapes;

                [NativeTypeName("ufbx_cache_deformer_list")]
                public CacheDeformerList cache_deformers;

                [NativeTypeName("ufbx_cache_file_list")]
                public CacheFileList cache_files;

                [NativeTypeName("ufbx_material_list")]
                public MaterialList materials;

                [NativeTypeName("ufbx_texture_list")]
                public TextureList textures;

                [NativeTypeName("ufbx_video_list")]
                public VideoList videos;

                [NativeTypeName("ufbx_shader_list")]
                public ShaderList shaders;

                [NativeTypeName("ufbx_shader_binding_list")]
                public ShaderBindingList shader_bindings;

                [NativeTypeName("ufbx_anim_stack_list")]
                public AnimStackList anim_stacks;

                [NativeTypeName("ufbx_anim_layer_list")]
                public AnimLayerList anim_layers;

                [NativeTypeName("ufbx_anim_value_list")]
                public AnimValueList anim_values;

                [NativeTypeName("ufbx_anim_curve_list")]
                public AnimCurveList anim_curves;

                [NativeTypeName("ufbx_display_layer_list")]
                public DisplayLayerList display_layers;

                [NativeTypeName("ufbx_selection_set_list")]
                public SelectionSetList selection_sets;

                [NativeTypeName("ufbx_selection_node_list")]
                public SelectionNodeList selection_nodes;

                [NativeTypeName("ufbx_character_list")]
                public CharacterList characters;

                [NativeTypeName("ufbx_constraint_list")]
                public ConstraintList constraints;

                [NativeTypeName("ufbx_pose_list")]
                public PoseList poses;

                [NativeTypeName("ufbx_metadata_object_list")]
                public MetadataObjectList metadata_objects;
            }

            public partial struct _elements_by_type_e__FixedBuffer
            {
                public ElementList e0;
                public ElementList e1;
                public ElementList e2;
                public ElementList e3;
                public ElementList e4;
                public ElementList e5;
                public ElementList e6;
                public ElementList e7;
                public ElementList e8;
                public ElementList e9;
                public ElementList e10;
                public ElementList e11;
                public ElementList e12;
                public ElementList e13;
                public ElementList e14;
                public ElementList e15;
                public ElementList e16;
                public ElementList e17;
                public ElementList e18;
                public ElementList e19;
                public ElementList e20;
                public ElementList e21;
                public ElementList e22;
                public ElementList e23;
                public ElementList e24;
                public ElementList e25;
                public ElementList e26;
                public ElementList e27;
                public ElementList e28;
                public ElementList e29;
                public ElementList e30;
                public ElementList e31;
                public ElementList e32;
                public ElementList e33;
                public ElementList e34;
                public ElementList e35;
                public ElementList e36;
                public ElementList e37;
                public ElementList e38;

                public unsafe ref ElementList this[int index]
                {
                    get
                    {
                        fixed (ElementList* pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }
    }
}
