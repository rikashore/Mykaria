namespace GCCJITSharp.Interop;

public unsafe class Block(gcc_jit_block* block)
{
    private gcc_jit_block* _block = block;

    public void AddEval(Location location, RValue rValue)
        => gccjit.block_add_eval(_block, location, rValue);

    public void EndWithReturn(Location location, RValue rValue)
        => gccjit.block_end_with_return(_block, location, rValue);
    
    public void EndWithVoidReturn(Location location)
        => gccjit.block_end_with_void_return(_block, location);

    public static implicit operator gcc_jit_block*(Block b) => b._block;
    public static implicit operator Block(gcc_jit_block* b) => new(b);
}