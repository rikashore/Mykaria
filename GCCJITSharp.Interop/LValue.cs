namespace GCCJITSharp.Interop;

public unsafe class LValue(gcc_jit_lvalue* lvalue)
{
    private gcc_jit_lvalue* _lValue = lvalue;

    public static implicit operator gcc_jit_lvalue*(LValue l) => l._lValue;
    public static implicit operator LValue(gcc_jit_lvalue* l) => new(l);
}