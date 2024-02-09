namespace GCCJITSharp.Interop;

[NativeTypeName("unsigned int")]
public enum gcc_jit_global_kind : uint
{
    GCC_JIT_GLOBAL_EXPORTED,
    GCC_JIT_GLOBAL_INTERNAL,
    GCC_JIT_GLOBAL_IMPORTED,
}
