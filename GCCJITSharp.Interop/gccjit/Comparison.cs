namespace GCCJITSharp.Interop;

[NativeTypeName("unsigned int")]
public enum Comparison : uint
{
    GCC_JIT_COMPARISON_EQ,
    GCC_JIT_COMPARISON_NE,
    GCC_JIT_COMPARISON_LT,
    GCC_JIT_COMPARISON_LE,
    GCC_JIT_COMPARISON_GT,
    GCC_JIT_COMPARISON_GE,
}
