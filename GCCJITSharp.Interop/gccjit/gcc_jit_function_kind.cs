namespace GCCJITSharp.Interop;

[NativeTypeName("unsigned int")]
public enum gcc_jit_function_kind : uint
{
    GCC_JIT_FUNCTION_EXPORTED,
    GCC_JIT_FUNCTION_INTERNAL,
    GCC_JIT_FUNCTION_IMPORTED,
    GCC_JIT_FUNCTION_ALWAYS_INLINE,
}
