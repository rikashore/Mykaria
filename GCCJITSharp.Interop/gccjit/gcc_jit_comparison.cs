namespace GCCJITSharp.Interop;

[NativeTypeName("unsigned int")]
public enum gcc_jit_comparison : uint
{
    GCC_JIT_COMPARISON_EQ,
    GCC_JIT_COMPARISON_NE,
    GCC_JIT_COMPARISON_LT,
    GCC_JIT_COMPARISON_LE,
    GCC_JIT_COMPARISON_GT,
    GCC_JIT_COMPARISON_GE,
}
