namespace GCCJITSharp.Interop;

[NativeTypeName("unsigned int")]
public enum GlobalKind : uint
{
    GCC_JIT_GLOBAL_EXPORTED,
    GCC_JIT_GLOBAL_INTERNAL,
    GCC_JIT_GLOBAL_IMPORTED,
}
