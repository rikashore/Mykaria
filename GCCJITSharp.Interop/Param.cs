namespace GCCJITSharp.Interop;

public unsafe class Param(gcc_jit_param* param)
{
    private gcc_jit_param* _param = param;

    public LValue AsLValue()
        => gccjit.param_as_lvalue(_param);

    public RValue AsRValue()
        => gccjit.param_as_rvalue(_param);

    public static implicit operator gcc_jit_param*(Param p) => p._param;
    public static implicit operator Param(gcc_jit_param* p) => new(p);
}