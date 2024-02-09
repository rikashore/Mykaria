namespace GCCJITSharp.Interop;

[NativeTypeName("unsigned int")]
public enum gcc_jit_unary_op : uint
{
    GCC_JIT_UNARY_OP_MINUS,
    GCC_JIT_UNARY_OP_BITWISE_NEGATE,
    GCC_JIT_UNARY_OP_LOGICAL_NEGATE,
    GCC_JIT_UNARY_OP_ABS,
}
