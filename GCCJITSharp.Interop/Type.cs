namespace GCCJITSharp.Interop;

public unsafe class Type(gcc_jit_type* type)
{
    private gcc_jit_type* _type = type;

    public Type GetPointer()
        => gccjit.type_get_pointer(_type);

    public Type GetConst()
        => gccjit.type_get_const(_type);

    public Type GetVolatile()
        => gccjit.type_get_volatile(_type);

    public Type GetAligned(nuint n)
        => gccjit.type_get_aligned(_type, n);

    public Type GetVector(nuint n)
        => gccjit.type_get_vector(_type, n);

    public static implicit operator gcc_jit_type*(Type t) => t._type;
    public static implicit operator Type(gcc_jit_type* t) => new(t);
}