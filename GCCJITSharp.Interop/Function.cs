namespace GCCJITSharp.Interop;

public unsafe class Function(gcc_jit_function* function)
{
    private gcc_jit_function* _function = function;

    public Param GetParam(int index)
        => gccjit.function_get_param(_function, index);

    public LValue CreateLocal(Location location, Type ty, string name) 
        => gccjit.function_new_local(_function, location, ty, name);

    public Block CreateBlock(string name) 
        => gccjit.function_new_block(_function, name);

    public static implicit operator gcc_jit_function*(Function f) => f._function;
    public static implicit operator Function(gcc_jit_function* f) => new(f);
}