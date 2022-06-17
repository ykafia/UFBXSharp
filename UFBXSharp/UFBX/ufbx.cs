using System;
using System.Runtime.InteropServices;

namespace UFBX.Interop
{
    public static unsafe partial class ufbx
    {
        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_load_memory", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_scene *")]
        public static extern Scene* load_memory([NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr size, [NativeTypeName("const ufbx_load_opts *")] LoadOpts* opts, [NativeTypeName("ufbx_error *")] Error* error);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_load_file", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_scene *")]
        public static extern Scene* load_file([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("const ufbx_load_opts *")] LoadOpts* opts, [NativeTypeName("ufbx_error *")] Error* error);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_load_file_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_scene *")]
        public static extern Scene* load_file_len([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("size_t")] UIntPtr filename_len, [NativeTypeName("const ufbx_load_opts *")] LoadOpts* opts, [NativeTypeName("ufbx_error *")] Error* error);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_load_stdio", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_scene *")]
        public static extern Scene* load_stdio(void* file, [NativeTypeName("const ufbx_load_opts *")] LoadOpts* opts, [NativeTypeName("ufbx_error *")] Error* error);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_load_stream", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_scene *")]
        public static extern Scene* load_stream([NativeTypeName("const void *")] void* prefix, [NativeTypeName("size_t")] UIntPtr prefix_size, [NativeTypeName("const ufbx_stream *")] Stream* stream, [NativeTypeName("const ufbx_load_opts *")] LoadOpts* opts, [NativeTypeName("ufbx_error *")] Error* error);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_free_scene", ExactSpelling = true)]
        public static extern void free_scene([NativeTypeName("ufbx_scene *")] Scene* scene);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_format_error", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr format_error([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("size_t")] UIntPtr dst_size, [NativeTypeName("const ufbx_error *")] Error* error);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_prop_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_prop *")]
        public static extern Prop* find_prop_len([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [return: NativeTypeName("ufbx_prop *")]
        public static Prop* find_prop([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name)
        {
            return find_prop_len(props, name, strlen(name));
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_real_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern Real find_real_len([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, [NativeTypeName("ufbx_real")] Real def);

        [return: NativeTypeName("ufbx_real")]
        public static Real find_real([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("ufbx_real")] Real def)
        {
            return find_real_len(props, name, strlen(name), def);
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_vec3_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_vec3")]
        public static extern Vec3 find_vec3_len([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, [NativeTypeName("ufbx_vec3")] Vec3 def);

        [return: NativeTypeName("ufbx_vec3")]
        public static Vec3 find_vec3([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("ufbx_vec3")] Vec3 def)
        {
            return find_vec3_len(props, name, strlen(name), def);
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_int_len", ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long find_int_len([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, [NativeTypeName("int64_t")] long def);

        [return: NativeTypeName("int64_t")]
        public static long find_int([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("int64_t")] long def)
        {
            return find_int_len(props, name, strlen(name), def);
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_bool_len", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte find_bool_len([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, [NativeTypeName("_Bool")] byte def);

        [return: NativeTypeName("_Bool")]
        public static bool find_bool([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("_Bool")] bool def)
        {
            return find_bool_len(props, name, strlen(name), def);
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_string_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_string")]
        public static extern String find_string_len([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, [NativeTypeName("ufbx_string")] String def);

        [return: NativeTypeName("ufbx_string")]
        public static String find_string([NativeTypeName("const ufbx_props *")] Props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("ufbx_string")] String def)
        {
            return find_string_len(props, name, strlen(name), def);
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_element_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_element *")]
        public static extern Element* find_element_len([NativeTypeName("ufbx_scene *")] Scene* scene, [NativeTypeName("ufbx_element_type")] ElementType type, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [return: NativeTypeName("ufbx_element *")]
        public static Element* find_element([NativeTypeName("ufbx_scene *")] Scene* scene, [NativeTypeName("ufbx_element_type")] ElementType type, [NativeTypeName("const char *")] sbyte* name)
        {
            return find_element_len(scene, type, name, strlen(name));
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_node_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_node *")]
        public static extern Node* find_node_len([NativeTypeName("ufbx_scene *")] Scene* scene, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [return: NativeTypeName("ufbx_node *")]
        public static Node* find_node([NativeTypeName("ufbx_scene *")] Scene* scene, [NativeTypeName("const char *")] sbyte* name)
        {
            return find_node_len(scene, name, strlen(name));
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_anim_stack_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_anim_stack *")]
        public static extern AnimStack* find_anim_stack_len([NativeTypeName("ufbx_scene *")] Scene* scene, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [return: NativeTypeName("ufbx_anim_stack *")]
        public static AnimStack* find_anim_stack([NativeTypeName("ufbx_scene *")] Scene* scene, [NativeTypeName("const char *")] sbyte* name)
        {
            return find_anim_stack_len(scene, name, strlen(name));
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_anim_prop_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_anim_prop *")]
        public static extern AnimProp* find_anim_prop_len([NativeTypeName("ufbx_anim_layer *")] AnimLayer* layer, [NativeTypeName("ufbx_element *")] Element* element, [NativeTypeName("const char *")] sbyte* prop, [NativeTypeName("size_t")] UIntPtr prop_len);

        [return: NativeTypeName("ufbx_anim_prop *")]
        public static AnimProp* find_anim_prop([NativeTypeName("ufbx_anim_layer *")] AnimLayer* layer, [NativeTypeName("ufbx_element *")] Element* element, [NativeTypeName("const char *")] sbyte* prop)
        {
            return find_anim_prop_len(layer, element, prop, strlen(prop));
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_anim_props", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_anim_prop_list")]
        public static extern AnimPropList find_anim_props([NativeTypeName("ufbx_anim_layer *")] AnimLayer* layer, [NativeTypeName("ufbx_element *")] Element* element);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_get_compatible_matrix_for_normals", ExactSpelling = true)]
        public static extern ufbx_matrix get_compatible_matrix_for_normals([NativeTypeName("ufbx_node *")] Node* node);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_inflate", ExactSpelling = true)]
        [return: NativeTypeName("ptrdiff_t")]
        public static extern IntPtr inflate(void* dst, [NativeTypeName("size_t")] UIntPtr dst_size, [NativeTypeName("const ufbx_inflate_input *")] InflateInput* input, [NativeTypeName("ufbx_inflate_retain *")] InflateRetainub* retain);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_open_file", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte open_file(void* user, [NativeTypeName("ufbx_stream *")] Stream* stream, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("size_t")] UIntPtr path_len);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_curve", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern Real evaluate_curve([NativeTypeName("const ufbx_anim_curve *")] AnimCurve* curve, double time, [NativeTypeName("ufbx_real")] Real default_value);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_anim_value_real", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern Real evaluate_anim_value_real([NativeTypeName("const ufbx_anim_value *")] AnimValue* anim_value, double time);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_anim_value_vec2", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_vec2")]
        public static extern Vec2 evaluate_anim_value_vec2([NativeTypeName("const ufbx_anim_value *")] AnimValue* anim_value, double time);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_anim_value_vec3", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_vec3")]
        public static extern Vec3 evaluate_anim_value_vec3([NativeTypeName("const ufbx_anim_value *")] AnimValue* anim_value, double time);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_prop_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_prop")]
        public static extern Prop evaluate_prop_len([NativeTypeName("const ufbx_anim *")] Anim* anim, [NativeTypeName("const ufbx_element *")] Element* element, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, double time);

        [return: NativeTypeName("ufbx_prop")]
        public static Prop evaluate_prop([NativeTypeName("const ufbx_anim *")] Anim* anim, [NativeTypeName("const ufbx_element *")] Element* element, [NativeTypeName("const char *")] sbyte* name, double time)
        {
            return evaluate_prop_len(anim, element, name, strlen(name), time);
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_props", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_props")]
        public static extern Props evaluate_props([NativeTypeName("const ufbx_anim *")] Anim* anim, [NativeTypeName("ufbx_element *")] Element* element, double time, [NativeTypeName("ufbx_prop *")] Prop* buffer, [NativeTypeName("size_t")] UIntPtr buffer_size);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_transform", ExactSpelling = true)]
        public static extern ufbx_transform evaluate_transform([NativeTypeName("const ufbx_anim *")] Anim* anim, [NativeTypeName("const ufbx_node *")] Node* node, double time);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_blend_weight", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern Real evaluate_blend_weight([NativeTypeName("const ufbx_anim *")] Anim* anim, [NativeTypeName("const ufbx_blend_channel *")] BlendChannel* channel, double time);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_prepare_prop_overrides", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_const_prop_override_list")]
        public static extern ConstPropOverrideList prepare_prop_overrides([NativeTypeName("ufbx_prop_override *")] PropOverride* overrides, [NativeTypeName("size_t")] UIntPtr num_overrides);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_scene", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_scene *")]
        public static extern Scene* evaluate_scene([NativeTypeName("ufbx_scene *")] Scene* scene, [NativeTypeName("const ufbx_anim *")] Anim* anim, double time, [NativeTypeName("const ufbx_evaluate_opts *")] EvaluateOpts* opts, [NativeTypeName("ufbx_error *")] Error* error);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_prop_texture_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_texture *")]
        public static extern Texture* find_prop_texture_len([NativeTypeName("const ufbx_material *")] Material* material, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [return: NativeTypeName("ufbx_texture *")]
        public static Texture* find_prop_texture([NativeTypeName("const ufbx_material *")] Material* material, [NativeTypeName("const char *")] sbyte* name)
        {
            return find_prop_texture_len(material, name, strlen(name));
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_find_shader_prop_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_string")]
        public static extern String find_shader_prop_len([NativeTypeName("const ufbx_shader *")] Shader* shader, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [return: NativeTypeName("ufbx_string")]
        public static String find_shader_prop([NativeTypeName("const ufbx_shader *")] Shader* shader, [NativeTypeName("const char *")] sbyte* name)
        {
            return find_shader_prop_len(shader, name, strlen(name));
        }

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_coordinate_axes_valid", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte coordinate_axes_valid([NativeTypeName("ufbx_coordinate_axes")] CoordinateAxes axes);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_quat_mul", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_quat")]
        public static extern Quat quat_mul([NativeTypeName("ufbx_quat")] Quat a, [NativeTypeName("ufbx_quat")] Quat b);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_quat_normalize", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_quat")]
        public static extern Quat quat_normalize([NativeTypeName("ufbx_quat")] Quat q);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_quat_fix_antipodal", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_quat")]
        public static extern Quat quat_fix_antipodal([NativeTypeName("ufbx_quat")] Quat q, [NativeTypeName("ufbx_quat")] Quat reference);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_quat_slerp", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_quat")]
        public static extern Quat quat_slerp([NativeTypeName("ufbx_quat")] Quat a, [NativeTypeName("ufbx_quat")] Quat b, [NativeTypeName("ufbx_real")] Real t);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_quat_rotate_vec3", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_vec3")]
        public static extern Vec3 quat_rotate_vec3([NativeTypeName("ufbx_quat")] Quat q, [NativeTypeName("ufbx_vec3")] Vec3 v);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_quat_to_euler", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_vec3")]
        public static extern Vec3 quat_to_euler([NativeTypeName("ufbx_quat")] Quat q, ufbx_rotation_order order);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_euler_to_quat", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_quat")]
        public static extern Quat euler_to_quat([NativeTypeName("ufbx_vec3")] Vec3 v, ufbx_rotation_order order);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_matrix_mul", ExactSpelling = true)]
        public static extern ufbx_matrix matrix_mul([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* a, [NativeTypeName("const ufbx_matrix *")] ufbx_matrix* b);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_matrix_determinant", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern Real matrix_determinant([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_matrix_invert", ExactSpelling = true)]
        public static extern ufbx_matrix matrix_invert([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_matrix_for_normals", ExactSpelling = true)]
        public static extern ufbx_matrix matrix_for_normals([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_transform_position", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_vec3")]
        public static extern Vec3 transform_position([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m, [NativeTypeName("ufbx_vec3")] Vec3 v);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_transform_direction", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_vec3")]
        public static extern Vec3 transform_direction([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m, [NativeTypeName("ufbx_vec3")] Vec3 v);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_transform_to_matrix", ExactSpelling = true)]
        public static extern ufbx_matrix transform_to_matrix([NativeTypeName("const ufbx_transform *")] ufbx_transform* t);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_matrix_to_transform", ExactSpelling = true)]
        public static extern ufbx_transform matrix_to_transform([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_get_skin_vertex_matrix", ExactSpelling = true)]
        public static extern ufbx_matrix get_skin_vertex_matrix([NativeTypeName("const ufbx_skin_deformer *")] SkinDeformer* skin, [NativeTypeName("size_t")] UIntPtr vertex, [NativeTypeName("const ufbx_matrix *")] ufbx_matrix* fallback);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_get_blend_shape_vertex_offset", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_vec3")]
        public static extern Vec3 get_blend_shape_vertex_offset([NativeTypeName("const ufbx_blend_shape *")] BlendShape* shape, [NativeTypeName("size_t")] UIntPtr vertex);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_get_blend_vertex_offset", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_vec3")]
        public static extern Vec3 get_blend_vertex_offset([NativeTypeName("const ufbx_blend_deformer *")] BlendDeformer* blend, [NativeTypeName("size_t")] UIntPtr vertex);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_add_blend_shape_vertex_offsets", ExactSpelling = true)]
        public static extern void add_blend_shape_vertex_offsets([NativeTypeName("const ufbx_blend_shape *")] BlendShape* shape, [NativeTypeName("ufbx_vec3 *")] Vec3* vertices, [NativeTypeName("size_t")] UIntPtr num_vertices, [NativeTypeName("ufbx_real")] Real weight);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_add_blend_vertex_offsets", ExactSpelling = true)]
        public static extern void add_blend_vertex_offsets([NativeTypeName("const ufbx_blend_deformer *")] BlendDeformer* blend, [NativeTypeName("ufbx_vec3 *")] Vec3* vertices, [NativeTypeName("size_t")] UIntPtr num_vertices, [NativeTypeName("ufbx_real")] Real weight);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_nurbs_basis", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr evaluate_nurbs_basis([NativeTypeName("const ufbx_nurbs_basis *")] NurbsBasis* basis, [NativeTypeName("ufbx_real")] Real u, [NativeTypeName("size_t")] UIntPtr num_weights, [NativeTypeName("ufbx_real *")] Real* weights, [NativeTypeName("ufbx_real *")] Real* derivatives);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_nurbs_curve", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_curve_point")]
        public static extern CurvePoint evaluate_nurbs_curve([NativeTypeName("const ufbx_nurbs_curve *")] NurbsCurve* curve, [NativeTypeName("ufbx_real")] Real u);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_evaluate_nurbs_surface", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_surface_point")]
        public static extern SurfacePoint evaluate_nurbs_surface([NativeTypeName("const ufbx_nurbs_surface *")] NurbsSurface* surface, [NativeTypeName("ufbx_real")] Real u, [NativeTypeName("ufbx_real")] Real v);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_tessellate_nurbs_surface", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_mesh *")]
        public static extern Mesh* tessellate_nurbs_surface([NativeTypeName("const ufbx_nurbs_surface *")] NurbsSurface* surface, [NativeTypeName("const ufbx_tessellate_opts *")] TessellateOpts* opts, [NativeTypeName("ufbx_error *")] Error* error);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_triangulate_face", ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint triangulate_face([NativeTypeName("uint32_t *")] uint* indices, [NativeTypeName("size_t")] UIntPtr num_indices, [NativeTypeName("const ufbx_mesh *")] Mesh* mesh, [NativeTypeName("ufbx_face")] Face face);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_compute_topology", ExactSpelling = true)]
        public static extern void compute_topology([NativeTypeName("const ufbx_mesh *")] Mesh* mesh, [NativeTypeName("ufbx_topo_edge *")] TopoEdge* topo);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_topo_next_vertex_edge", ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int topo_next_vertex_edge([NativeTypeName("const ufbx_topo_edge *")] TopoEdge* topo, [NativeTypeName("int32_t")] int index);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_topo_prev_vertex_edge", ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int topo_prev_vertex_edge([NativeTypeName("const ufbx_topo_edge *")] TopoEdge* topo, [NativeTypeName("int32_t")] int index);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_get_weighted_face_normal", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_vec3")]
        public static extern Vec3 get_weighted_face_normal([NativeTypeName("const ufbx_vertex_vec3 *")] VertexVec3* positions, [NativeTypeName("ufbx_face")] Face face);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_generate_normal_mapping", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr generate_normal_mapping([NativeTypeName("const ufbx_mesh *")] Mesh* mesh, [NativeTypeName("ufbx_topo_edge *")] TopoEdge* topo, [NativeTypeName("int32_t *")] int* normal_indices, [NativeTypeName("_Bool")] byte assume_smooth);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_compute_normals", ExactSpelling = true)]
        public static extern void compute_normals([NativeTypeName("const ufbx_mesh *")] Mesh* mesh, [NativeTypeName("const ufbx_vertex_vec3 *")] VertexVec3* positions, [NativeTypeName("int32_t *")] int* normal_indices, [NativeTypeName("ufbx_vec3 *")] Vec3* normals, [NativeTypeName("size_t")] UIntPtr num_normals);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_subdivide_mesh", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_mesh *")]
        public static extern Mesh* subdivide_mesh([NativeTypeName("const ufbx_mesh *")] Mesh* mesh, [NativeTypeName("size_t")] UIntPtr level, [NativeTypeName("const ufbx_subdivide_opts *")] SubdivideOpts* opts, [NativeTypeName("ufbx_error *")] Error* error);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_free_mesh", ExactSpelling = true)]
        public static extern void free_mesh([NativeTypeName("ufbx_mesh *")] Mesh* mesh);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_load_geometry_cache", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_geometry_cache *")]
        public static extern GeometryCache* load_geometry_cache([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("const ufbx_geometry_cache_opts *")] GeometryCacheOpts* opts, [NativeTypeName("ufbx_error *")] Error* error);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_load_geometry_cache_len", ExactSpelling = true)]
        [return: NativeTypeName("ufbx_geometry_cache *")]
        public static extern GeometryCache* load_geometry_cache_len([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("size_t")] UIntPtr filename_len, [NativeTypeName("const ufbx_geometry_cache_opts *")] GeometryCacheOpts* opts, [NativeTypeName("ufbx_error *")] Error* error);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_free_geometry_cache", ExactSpelling = true)]
        public static extern void free_geometry_cache([NativeTypeName("ufbx_geometry_cache *")] GeometryCache* cache);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_read_geometry_cache_real", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr read_geometry_cache_real([NativeTypeName("const ufbx_cache_frame *")] CacheFrame* frame, [NativeTypeName("ufbx_real *")] Real* data, [NativeTypeName("size_t")] UIntPtr count, [NativeTypeName("ufbx_geometry_cache_data_opts *")] GeometryCacheDataOpts* opts);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_sample_geometry_cache_real", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr sample_geometry_cache_real([NativeTypeName("const ufbx_cache_channel *")] CacheChannel* channel, double time, [NativeTypeName("ufbx_real *")] Real* data, [NativeTypeName("size_t")] UIntPtr count, [NativeTypeName("ufbx_geometry_cache_data_opts *")] GeometryCacheDataOpts* opts);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_read_geometry_cache_vec3", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr read_geometry_cache_vec3([NativeTypeName("const ufbx_cache_frame *")] CacheFrame* frame, [NativeTypeName("ufbx_vec3 *")] Vec3* data, [NativeTypeName("size_t")] UIntPtr count, [NativeTypeName("ufbx_geometry_cache_data_opts *")] GeometryCacheDataOpts* opts);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_sample_geometry_cache_vec3", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr sample_geometry_cache_vec3([NativeTypeName("const ufbx_cache_channel *")] CacheChannel* channel, double time, [NativeTypeName("ufbx_vec3 *")] Vec3* data, [NativeTypeName("size_t")] UIntPtr count, [NativeTypeName("ufbx_geometry_cache_data_opts *")] GeometryCacheDataOpts* opts);

        [DllImport("", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ufbx_generate_indices", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr generate_indices([NativeTypeName("const ufbx_vertex_stream *")] VertexStream* streams, [NativeTypeName("size_t")] UIntPtr num_streams, [NativeTypeName("uint32_t *")] uint* indices, [NativeTypeName("size_t")] UIntPtr num_indices, [NativeTypeName("const ufbx_allocator *")] Allocator* allocator, [NativeTypeName("ufbx_error *")] Error* error);

        [return: NativeTypeName("ufbx_real")]
        public static Real get_vertex_real([NativeTypeName("const ufbx_vertex_real *")] VertexReal* v, [NativeTypeName("size_t")] UIntPtr index)
        {
            return v->data[v->indices[index]];
        }

        [return: NativeTypeName("ufbx_vec2")]
        public static Vec2 get_vertex_vec2([NativeTypeName("const ufbx_vertex_vec2 *")] VertexVec2* v, [NativeTypeName("size_t")] UIntPtr index)
        {
            return v->data[v->indices[index]];
        }

        [return: NativeTypeName("ufbx_vec3")]
        public static Vec3 get_vertex_vec3([NativeTypeName("const ufbx_vertex_vec3 *")] VertexVec3* v, [NativeTypeName("size_t")] UIntPtr index)
        {
            return v->data[v->indices[index]];
        }

        [return: NativeTypeName("ufbx_vec4")]
        public static Vec4 get_vertex_vec4([NativeTypeName("const ufbx_vertex_vec4 *")] VertexVec4* v, [NativeTypeName("size_t")] UIntPtr index)
        {
            return v->data[v->indices[index]];
        }
    }
}
