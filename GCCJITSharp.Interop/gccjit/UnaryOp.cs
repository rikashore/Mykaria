namespace GCCJITSharp.Interop;

[NativeTypeName("unsigned int")]
public enum UnaryOp : uint
{
    GCC_JIT_UNARY_OP_MINUS,
    GCC_JIT_UNARY_OP_BITWISE_NEGATE,
    GCC_JIT_UNARY_OP_LOGICAL_NEGATE,
    GCC_JIT_UNARY_OP_ABS,
}
