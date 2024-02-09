namespace GCCJITSharp.Interop;

[NativeTypeName("unsigned int")]
public enum gcc_jit_tls_model : uint
{
    GCC_JIT_TLS_MODEL_NONE,
    GCC_JIT_TLS_MODEL_GLOBAL_DYNAMIC,
    GCC_JIT_TLS_MODEL_LOCAL_DYNAMIC,
    GCC_JIT_TLS_MODEL_INITIAL_EXEC,
    GCC_JIT_TLS_MODEL_LOCAL_EXEC,
}
