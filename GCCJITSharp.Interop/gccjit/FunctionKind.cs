namespace GCCJITSharp.Interop;

[NativeTypeName("unsigned int")]
public enum FunctionKind : uint
{
    GCC_JIT_FUNCTION_EXPORTED,
    GCC_JIT_FUNCTION_INTERNAL,
    GCC_JIT_FUNCTION_IMPORTED,
    GCC_JIT_FUNCTION_ALWAYS_INLINE,
}
