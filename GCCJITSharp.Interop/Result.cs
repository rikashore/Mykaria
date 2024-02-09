namespace GCCJITSharp.Interop;

public unsafe class Result(gcc_jit_result* result)
{
    private gcc_jit_result* _result = result;

    public void* GetCode(string name) 
        => gccjit.result_get_code(_result, name);

    public void Release()
        => gccjit.result_release(_result);

    public static implicit operator gcc_jit_result*(Result r) => r._result;
    public static implicit operator Result(gcc_jit_result* r) => new(r);
}