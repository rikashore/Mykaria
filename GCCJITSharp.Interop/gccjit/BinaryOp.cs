namespace GCCJITSharp.Interop;

[NativeTypeName("unsigned int")]
public enum BinaryOp : uint
{
    GCC_JIT_BINARY_OP_PLUS,
    GCC_JIT_BINARY_OP_MINUS,
    GCC_JIT_BINARY_OP_MULT,
    GCC_JIT_BINARY_OP_DIVIDE,
    GCC_JIT_BINARY_OP_MODULO,
    GCC_JIT_BINARY_OP_BITWISE_AND,
    GCC_JIT_BINARY_OP_BITWISE_XOR,
    GCC_JIT_BINARY_OP_BITWISE_OR,
    GCC_JIT_BINARY_OP_LOGICAL_AND,
    GCC_JIT_BINARY_OP_LOGICAL_OR,
    GCC_JIT_BINARY_OP_LSHIFT,
    GCC_JIT_BINARY_OP_RSHIFT,
}
