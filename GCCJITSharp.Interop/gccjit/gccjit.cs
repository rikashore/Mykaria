using System.Runtime.InteropServices;

namespace GCCJITSharp.Interop;

public static unsafe partial class gccjit
{
    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_acquire", ExactSpelling = true)]
    public static extern gcc_jit_context* context_acquire();

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_release", ExactSpelling = true)]
    public static extern void context_release(gcc_jit_context* ctxt);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_set_str_option", ExactSpelling = true)]
    public static extern void context_set_str_option(gcc_jit_context* ctxt, [NativeTypeName("enum gcc_jit_str_option")] StrOption opt, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_set_int_option", ExactSpelling = true)]
    public static extern void context_set_int_option(gcc_jit_context* ctxt, [NativeTypeName("enum gcc_jit_int_option")] IntOption opt, int value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_set_bool_option", ExactSpelling = true)]
    public static extern void context_set_bool_option(gcc_jit_context* ctxt, [NativeTypeName("enum gcc_jit_bool_option")] BoolOption opt, int value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_set_bool_allow_unreachable_blocks", ExactSpelling = true)]
    public static extern void context_set_bool_allow_unreachable_blocks(gcc_jit_context* ctxt, int bool_value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_set_bool_print_errors_to_stderr", ExactSpelling = true)]
    public static extern void context_set_bool_print_errors_to_stderr(gcc_jit_context* ctxt, int enabled);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_set_bool_use_external_driver", ExactSpelling = true)]
    public static extern void context_set_bool_use_external_driver(gcc_jit_context* ctxt, int bool_value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_add_command_line_option", ExactSpelling = true)]
    public static extern void context_add_command_line_option(gcc_jit_context* ctxt, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string optname);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_add_driver_option", ExactSpelling = true)]
    public static extern void context_add_driver_option(gcc_jit_context* ctxt, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string optname);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_compile", ExactSpelling = true)]
    public static extern gcc_jit_result* context_compile(gcc_jit_context* ctxt);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_compile_to_file", ExactSpelling = true)]
    public static extern void context_compile_to_file(gcc_jit_context* ctxt, [NativeTypeName("enum gcc_jit_output_kind")] OutputKind output_kind, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string output_path);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_dump_to_file", ExactSpelling = true)]
    public static extern void context_dump_to_file(gcc_jit_context* ctxt, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string path, int update_locations);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_set_logfile", ExactSpelling = true)]
    public static extern void context_set_logfile(gcc_jit_context* ctxt, [NativeTypeName("FILE *")] void* logfile, int flags, int verbosity);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_get_first_error", ExactSpelling = true, CharSet = CharSet.Unicode)]
    [return: NativeTypeName("const char *")]
    public static extern string context_get_first_error(gcc_jit_context* ctxt);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_get_last_error", ExactSpelling = true, CharSet = CharSet.Unicode)]
    [return: NativeTypeName("const char *")]
    public static extern string context_get_last_error(gcc_jit_context* ctxt);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_result_get_code", ExactSpelling = true)]
    public static extern void* result_get_code(gcc_jit_result* result, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string funcname);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_result_get_global", ExactSpelling = true)]
    public static extern void* result_get_global(gcc_jit_result* result, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_result_release", ExactSpelling = true)]
    public static extern void result_release(gcc_jit_result* result);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_object_get_context", ExactSpelling = true)]
    public static extern gcc_jit_context* object_get_context(gcc_jit_object* obj);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_object_get_debug_string", ExactSpelling = true, CharSet = CharSet.Unicode)]
    [return: NativeTypeName("const char *")]
    public static extern string object_get_debug_string(gcc_jit_object* obj);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_location", ExactSpelling = true)]
    public static extern gcc_jit_location* context_new_location(gcc_jit_context* ctxt, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string filename, int line, int column);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_location_as_object", ExactSpelling = true)]
    public static extern gcc_jit_object* location_as_object(gcc_jit_location* loc);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_as_object", ExactSpelling = true)]
    public static extern gcc_jit_object* type_as_object(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_get_type", ExactSpelling = true)]
    public static extern gcc_jit_type* context_get_type(gcc_jit_context* ctxt, [NativeTypeName("enum gcc_jit_types")] Types type_);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_get_int_type", ExactSpelling = true)]
    public static extern gcc_jit_type* context_get_int_type(gcc_jit_context* ctxt, int num_bytes, int is_signed);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_get_pointer", ExactSpelling = true)]
    public static extern gcc_jit_type* type_get_pointer(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_get_const", ExactSpelling = true)]
    public static extern gcc_jit_type* type_get_const(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_get_volatile", ExactSpelling = true)]
    public static extern gcc_jit_type* type_get_volatile(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_compatible_types", ExactSpelling = true)]
    public static extern int compatible_types(gcc_jit_type* ltype, gcc_jit_type* rtype);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_get_size", ExactSpelling = true)]
    [return: NativeTypeName("ssize_t")]
    public static extern nint type_get_size(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_array_type", ExactSpelling = true)]
    public static extern gcc_jit_type* context_new_array_type(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_type* element_type, int num_elements);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_field", ExactSpelling = true)]
    public static extern gcc_jit_field* context_new_field(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_type* type, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_bitfield", ExactSpelling = true)]
    public static extern gcc_jit_field* context_new_bitfield(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_type* type, int width, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_field_as_object", ExactSpelling = true)]
    public static extern gcc_jit_object* field_as_object(gcc_jit_field* field);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_struct_type", ExactSpelling = true)]
    public static extern gcc_jit_struct* context_new_struct_type(gcc_jit_context* ctxt, gcc_jit_location* loc, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name, int num_fields, gcc_jit_field** fields);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_opaque_struct", ExactSpelling = true)]
    public static extern gcc_jit_struct* context_new_opaque_struct(gcc_jit_context* ctxt, gcc_jit_location* loc, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_struct_as_type", ExactSpelling = true)]
    public static extern gcc_jit_type* struct_as_type(gcc_jit_struct* struct_type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_struct_set_fields", ExactSpelling = true)]
    public static extern void struct_set_fields(gcc_jit_struct* struct_type, gcc_jit_location* loc, int num_fields, gcc_jit_field** fields);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_struct_get_field", ExactSpelling = true)]
    public static extern gcc_jit_field* struct_get_field(gcc_jit_struct* struct_type, [NativeTypeName("size_t")] nuint index);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_struct_get_field_count", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint struct_get_field_count(gcc_jit_struct* struct_type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_union_type", ExactSpelling = true)]
    public static extern gcc_jit_type* context_new_union_type(gcc_jit_context* ctxt, gcc_jit_location* loc, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name, int num_fields, gcc_jit_field** fields);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_function_ptr_type", ExactSpelling = true)]
    public static extern gcc_jit_type* context_new_function_ptr_type(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_type* return_type, int num_params, gcc_jit_type** param_types, int is_variadic);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_param", ExactSpelling = true)]
    public static extern gcc_jit_param* context_new_param(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_type* type, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_param_as_object", ExactSpelling = true)]
    public static extern gcc_jit_object* param_as_object(gcc_jit_param* param0);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_param_as_lvalue", ExactSpelling = true)]
    public static extern gcc_jit_lvalue* param_as_lvalue(gcc_jit_param* param0);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_param_as_rvalue", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* param_as_rvalue(gcc_jit_param* param0);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_function", ExactSpelling = true)]
    public static extern gcc_jit_function* context_new_function(gcc_jit_context* ctxt, gcc_jit_location* loc, [NativeTypeName("enum gcc_jit_function_kind")] FunctionKind kind, gcc_jit_type* return_type, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name, int num_params, gcc_jit_param** @params, int is_variadic);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_get_builtin_function", ExactSpelling = true)]
    public static extern gcc_jit_function* context_get_builtin_function(gcc_jit_context* ctxt, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_function_as_object", ExactSpelling = true)]
    public static extern gcc_jit_object* function_as_object(gcc_jit_function* func);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_function_get_param", ExactSpelling = true)]
    public static extern gcc_jit_param* function_get_param(gcc_jit_function* func, int index);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_function_dump_to_dot", ExactSpelling = true)]
    public static extern void function_dump_to_dot(gcc_jit_function* func, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string path);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_function_new_block", ExactSpelling = true)]
    public static extern gcc_jit_block* function_new_block(gcc_jit_function* func, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_as_object", ExactSpelling = true)]
    public static extern gcc_jit_object* block_as_object(gcc_jit_block* block);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_get_function", ExactSpelling = true)]
    public static extern gcc_jit_function* block_get_function(gcc_jit_block* block);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_global", ExactSpelling = true)]
    public static extern gcc_jit_lvalue* context_new_global(gcc_jit_context* ctxt, gcc_jit_location* loc, [NativeTypeName("enum gcc_jit_global_kind")] GlobalKind kind, gcc_jit_type* type, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_struct_constructor", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_struct_constructor(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_type* type, [NativeTypeName("size_t")] nuint num_values, gcc_jit_field** fields, gcc_jit_rvalue** values);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_union_constructor", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_union_constructor(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_type* type, gcc_jit_field* field, gcc_jit_rvalue* value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_array_constructor", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_array_constructor(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_type* type, [NativeTypeName("size_t")] nuint num_values, gcc_jit_rvalue** values);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_global_set_initializer_rvalue", ExactSpelling = true)]
    public static extern gcc_jit_lvalue* global_set_initializer_rvalue(gcc_jit_lvalue* global, gcc_jit_rvalue* init_value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_global_set_initializer", ExactSpelling = true)]
    public static extern gcc_jit_lvalue* global_set_initializer(gcc_jit_lvalue* global, [NativeTypeName("const void *")] void* blob, [NativeTypeName("size_t")] nuint num_bytes);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_lvalue_as_object", ExactSpelling = true)]
    public static extern gcc_jit_object* lvalue_as_object(gcc_jit_lvalue* lvalue);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_lvalue_as_rvalue", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* lvalue_as_rvalue(gcc_jit_lvalue* lvalue);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_rvalue_as_object", ExactSpelling = true)]
    public static extern gcc_jit_object* rvalue_as_object(gcc_jit_rvalue* rvalue);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_rvalue_get_type", ExactSpelling = true)]
    public static extern gcc_jit_type* rvalue_get_type(gcc_jit_rvalue* rvalue);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_rvalue_from_int", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_rvalue_from_int(gcc_jit_context* ctxt, gcc_jit_type* numeric_type, int value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_rvalue_from_long", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_rvalue_from_long(gcc_jit_context* ctxt, gcc_jit_type* numeric_type, [NativeTypeName("long")] nint value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_zero", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_zero(gcc_jit_context* ctxt, gcc_jit_type* numeric_type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_one", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_one(gcc_jit_context* ctxt, gcc_jit_type* numeric_type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_rvalue_from_double", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_rvalue_from_double(gcc_jit_context* ctxt, gcc_jit_type* numeric_type, double value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_rvalue_from_ptr", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_rvalue_from_ptr(gcc_jit_context* ctxt, gcc_jit_type* pointer_type, void* value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_null", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_null(gcc_jit_context* ctxt, gcc_jit_type* pointer_type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_string_literal", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_string_literal(gcc_jit_context* ctxt, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string value);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_unary_op", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_unary_op(gcc_jit_context* ctxt, gcc_jit_location* loc, [NativeTypeName("enum gcc_jit_unary_op")] UnaryOp op, gcc_jit_type* result_type, gcc_jit_rvalue* rvalue);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_binary_op", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_binary_op(gcc_jit_context* ctxt, gcc_jit_location* loc, [NativeTypeName("enum gcc_jit_binary_op")] BinaryOp op, gcc_jit_type* result_type, gcc_jit_rvalue* a, gcc_jit_rvalue* b);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_comparison", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_comparison(gcc_jit_context* ctxt, gcc_jit_location* loc, [NativeTypeName("enum gcc_jit_comparison")] Comparison op, gcc_jit_rvalue* a, gcc_jit_rvalue* b);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_call", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_call(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_function* func, int numargs, gcc_jit_rvalue** args);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_call_through_ptr", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_call_through_ptr(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_rvalue* fn_ptr, int numargs, gcc_jit_rvalue** args);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_cast", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_cast(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_rvalue* rvalue, gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_bitcast", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_bitcast(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_rvalue* rvalue, gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_lvalue_set_alignment", ExactSpelling = true)]
    public static extern void lvalue_set_alignment(gcc_jit_lvalue* lvalue, [NativeTypeName("unsigned int")] uint bytes);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_lvalue_get_alignment", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint lvalue_get_alignment(gcc_jit_lvalue* lvalue);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_array_access", ExactSpelling = true)]
    public static extern gcc_jit_lvalue* context_new_array_access(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_rvalue* ptr, gcc_jit_rvalue* index);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_lvalue_access_field", ExactSpelling = true)]
    public static extern gcc_jit_lvalue* lvalue_access_field(gcc_jit_lvalue* struct_or_union, gcc_jit_location* loc, gcc_jit_field* field);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_rvalue_access_field", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* rvalue_access_field(gcc_jit_rvalue* struct_or_union, gcc_jit_location* loc, gcc_jit_field* field);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_rvalue_dereference_field", ExactSpelling = true)]
    public static extern gcc_jit_lvalue* rvalue_dereference_field(gcc_jit_rvalue* ptr, gcc_jit_location* loc, gcc_jit_field* field);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_rvalue_dereference", ExactSpelling = true)]
    public static extern gcc_jit_lvalue* rvalue_dereference(gcc_jit_rvalue* rvalue, gcc_jit_location* loc);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_lvalue_get_address", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* lvalue_get_address(gcc_jit_lvalue* lvalue, gcc_jit_location* loc);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_lvalue_set_tls_model", ExactSpelling = true)]
    public static extern void lvalue_set_tls_model(gcc_jit_lvalue* lvalue, [NativeTypeName("enum gcc_jit_tls_model")] gcc_jit_tls_model model);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_lvalue_set_link_section", ExactSpelling = true)]
    public static extern void lvalue_set_link_section(gcc_jit_lvalue* lvalue, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string section_name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_lvalue_set_register_name", ExactSpelling = true)]
    public static extern void lvalue_set_register_name(gcc_jit_lvalue* lvalue, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string reg_name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_function_new_local", ExactSpelling = true)]
    public static extern gcc_jit_lvalue* function_new_local(gcc_jit_function* func, gcc_jit_location* loc, gcc_jit_type* type, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_add_eval", ExactSpelling = true)]
    public static extern void block_add_eval(gcc_jit_block* block, gcc_jit_location* loc, gcc_jit_rvalue* rvalue);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_add_assignment", ExactSpelling = true)]
    public static extern void block_add_assignment(gcc_jit_block* block, gcc_jit_location* loc, gcc_jit_lvalue* lvalue, gcc_jit_rvalue* rvalue);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_add_assignment_op", ExactSpelling = true)]
    public static extern void block_add_assignment_op(gcc_jit_block* block, gcc_jit_location* loc, gcc_jit_lvalue* lvalue, [NativeTypeName("enum gcc_jit_binary_op")] BinaryOp op, gcc_jit_rvalue* rvalue);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_add_comment", ExactSpelling = true)]
    public static extern void block_add_comment(gcc_jit_block* block, gcc_jit_location* loc, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string text);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_end_with_conditional", ExactSpelling = true)]
    public static extern void block_end_with_conditional(gcc_jit_block* block, gcc_jit_location* loc, gcc_jit_rvalue* boolval, gcc_jit_block* on_true, gcc_jit_block* on_false);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_end_with_jump", ExactSpelling = true)]
    public static extern void block_end_with_jump(gcc_jit_block* block, gcc_jit_location* loc, gcc_jit_block* target);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_end_with_return", ExactSpelling = true)]
    public static extern void block_end_with_return(gcc_jit_block* block, gcc_jit_location* loc, gcc_jit_rvalue* rvalue);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_end_with_void_return", ExactSpelling = true)]
    public static extern void block_end_with_void_return(gcc_jit_block* block, gcc_jit_location* loc);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_case", ExactSpelling = true)]
    public static extern gcc_jit_case* context_new_case(gcc_jit_context* ctxt, gcc_jit_rvalue* min_value, gcc_jit_rvalue* max_value, gcc_jit_block* dest_block);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_case_as_object", ExactSpelling = true)]
    public static extern gcc_jit_object* case_as_object(gcc_jit_case* case_);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_end_with_switch", ExactSpelling = true)]
    public static extern void block_end_with_switch(gcc_jit_block* block, gcc_jit_location* loc, gcc_jit_rvalue* expr, gcc_jit_block* default_block, int num_cases, gcc_jit_case** cases);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_child_context", ExactSpelling = true)]
    public static extern gcc_jit_context* context_new_child_context(gcc_jit_context* parent_ctxt);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_dump_reproducer_to_file", ExactSpelling = true)]
    public static extern void context_dump_reproducer_to_file(gcc_jit_context* ctxt, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string path);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_enable_dump", ExactSpelling = true)]
    public static extern void context_enable_dump(gcc_jit_context* ctxt, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string dumpname, [NativeTypeName("char **")] [MarshalAs(UnmanagedType.LPStr)] string* out_ptr);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_timer_new", ExactSpelling = true)]
    public static extern gcc_jit_timer* timer_new();

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_timer_release", ExactSpelling = true)]
    public static extern void timer_release(gcc_jit_timer* timer);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_set_timer", ExactSpelling = true)]
    public static extern void context_set_timer(gcc_jit_context* ctxt, gcc_jit_timer* timer);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_get_timer", ExactSpelling = true)]
    public static extern gcc_jit_timer* context_get_timer(gcc_jit_context* ctxt);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_timer_push", ExactSpelling = true)]
    public static extern void timer_push(gcc_jit_timer* timer, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string item_name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_timer_pop", ExactSpelling = true)]
    public static extern void timer_pop(gcc_jit_timer* timer, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string item_name);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_timer_print", ExactSpelling = true)]
    public static extern void timer_print(gcc_jit_timer* timer, [NativeTypeName("FILE *")] void* f_out);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_rvalue_set_bool_require_tail_call", ExactSpelling = true)]
    public static extern void rvalue_set_bool_require_tail_call(gcc_jit_rvalue* call, int require_tail_call);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_get_aligned", ExactSpelling = true)]
    public static extern gcc_jit_type* type_get_aligned(gcc_jit_type* type, [NativeTypeName("size_t")] nuint alignment_in_bytes);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_get_vector", ExactSpelling = true)]
    public static extern gcc_jit_type* type_get_vector(gcc_jit_type* type, [NativeTypeName("size_t")] nuint num_units);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_function_get_address", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* function_get_address(gcc_jit_function* fn, gcc_jit_location* loc);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_new_rvalue_from_vector", ExactSpelling = true)]
    public static extern gcc_jit_rvalue* context_new_rvalue_from_vector(gcc_jit_context* ctxt, gcc_jit_location* loc, gcc_jit_type* vec_type, [NativeTypeName("size_t")] nuint num_elements, gcc_jit_rvalue** elements);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_version_major", ExactSpelling = true)]
    public static extern int version_major();

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_version_minor", ExactSpelling = true)]
    public static extern int version_minor();

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_version_patchlevel", ExactSpelling = true)]
    public static extern int version_patchlevel();

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_add_extended_asm", ExactSpelling = true)]
    public static extern gcc_jit_extended_asm* block_add_extended_asm(gcc_jit_block* block, gcc_jit_location* loc, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string asm_template);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_block_end_with_extended_asm_goto", ExactSpelling = true)]
    public static extern gcc_jit_extended_asm* block_end_with_extended_asm_goto(gcc_jit_block* block, gcc_jit_location* loc, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string asm_template, int num_goto_blocks, gcc_jit_block** goto_blocks, gcc_jit_block* fallthrough_block);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_extended_asm_as_object", ExactSpelling = true)]
    public static extern gcc_jit_object* extended_asm_as_object(gcc_jit_extended_asm* ext_asm);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_extended_asm_set_volatile_flag", ExactSpelling = true)]
    public static extern void extended_asm_set_volatile_flag(gcc_jit_extended_asm* ext_asm, int flag);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_extended_asm_set_inline_flag", ExactSpelling = true)]
    public static extern void extended_asm_set_inline_flag(gcc_jit_extended_asm* ext_asm, int flag);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_extended_asm_add_output_operand", ExactSpelling = true)]
    public static extern void extended_asm_add_output_operand(gcc_jit_extended_asm* ext_asm, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string asm_symbolic_name, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string constraint, gcc_jit_lvalue* dest);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_extended_asm_add_input_operand", ExactSpelling = true)]
    public static extern void extended_asm_add_input_operand(gcc_jit_extended_asm* ext_asm, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string asm_symbolic_name, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string constraint, gcc_jit_rvalue* src);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_extended_asm_add_clobber", ExactSpelling = true)]
    public static extern void extended_asm_add_clobber(gcc_jit_extended_asm* ext_asm, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string victim);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_context_add_top_level_asm", ExactSpelling = true)]
    public static extern void context_add_top_level_asm(gcc_jit_context* ctxt, gcc_jit_location* loc, [NativeTypeName("const char *")] [MarshalAs(UnmanagedType.LPStr)] string asm_stmts);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_function_get_return_type", ExactSpelling = true)]
    public static extern gcc_jit_type* function_get_return_type(gcc_jit_function* func);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_function_get_param_count", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint function_get_param_count(gcc_jit_function* func);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_dyncast_array", ExactSpelling = true)]
    public static extern gcc_jit_type* type_dyncast_array(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_is_bool", ExactSpelling = true)]
    public static extern int type_is_bool(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_dyncast_function_ptr_type", ExactSpelling = true)]
    public static extern gcc_jit_function_type* type_dyncast_function_ptr_type(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_function_type_get_return_type", ExactSpelling = true)]
    public static extern gcc_jit_type* function_type_get_return_type(gcc_jit_function_type* function_type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_function_type_get_param_count", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint function_type_get_param_count(gcc_jit_function_type* function_type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_function_type_get_param_type", ExactSpelling = true)]
    public static extern gcc_jit_type* function_type_get_param_type(gcc_jit_function_type* function_type, [NativeTypeName("size_t")] nuint index);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_is_integral", ExactSpelling = true)]
    public static extern int type_is_integral(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_is_pointer", ExactSpelling = true)]
    public static extern gcc_jit_type* type_is_pointer(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_dyncast_vector", ExactSpelling = true)]
    public static extern gcc_jit_vector_type* type_dyncast_vector(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_is_struct", ExactSpelling = true)]
    public static extern gcc_jit_struct* type_is_struct(gcc_jit_type* type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_vector_type_get_num_units", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint vector_type_get_num_units(gcc_jit_vector_type* vector_type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_vector_type_get_element_type", ExactSpelling = true)]
    public static extern gcc_jit_type* vector_type_get_element_type(gcc_jit_vector_type* vector_type);

    [DllImport("libgccjit.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "gcc_jit_type_unqualified", ExactSpelling = true)]
    public static extern gcc_jit_type* type_unqualified(gcc_jit_type* type);
}
