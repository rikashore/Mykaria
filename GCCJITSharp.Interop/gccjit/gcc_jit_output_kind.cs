namespace GCCJITSharp.Interop;

[NativeTypeName("unsigned int")]
public enum gcc_jit_output_kind : uint
{
    GCC_JIT_OUTPUT_KIND_ASSEMBLER,
    GCC_JIT_OUTPUT_KIND_OBJECT_FILE,
    GCC_JIT_OUTPUT_KIND_DYNAMIC_LIBRARY,
    GCC_JIT_OUTPUT_KIND_EXECUTABLE,
}
