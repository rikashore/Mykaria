namespace GCCJITSharp.Interop;

public unsafe class RValue(gcc_jit_rvalue* rvalue)
{
    private gcc_jit_rvalue* _rvalue = rvalue;

    public static implicit operator gcc_jit_rvalue*(RValue r) => r._rvalue;
    public static implicit operator RValue(gcc_jit_rvalue* r) => new(r);
}