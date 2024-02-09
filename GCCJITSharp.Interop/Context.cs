using System.Net;
using System.Text;

namespace GCCJITSharp.Interop;

public unsafe class Context
{
    private gcc_jit_context* _context;

    private Context(gcc_jit_context* context, bool isChild)
    {
        _context = isChild ? context : gccjit.context_acquire();
    }

    public static Context Create() 
        => new(null, false);

    public Context CreateChild() 
        => new(gccjit.context_new_child_context(_context), true);

    public string GetFirstError()
    {
        var message = gccjit.context_get_first_error(_context);
        return message;
    }
    
    public string GetLastError()
    {
        var message = gccjit.context_get_last_error(_context);
        return message;
    }

    public void SetBoolOption(BoolOption option, int value)
        => gccjit.context_set_bool_option(_context, option, value);

    public void SetStringOption(StrOption option, string value) 
        => gccjit.context_set_str_option(_context, option, value);

    public void AddCommandLineOption(string optname) 
        => gccjit.context_add_command_line_option(_context, optname);

    public void SetIntOption(IntOption option, int value)
        => gccjit.context_set_int_option(_context, option, value);

    public Type GetType(Types jitType)
        => gccjit.context_get_type(_context, jitType);

    public Type GetIntType(int numBytes, int isSigned)
        => gccjit.context_get_int_type(_context, numBytes, isSigned);
    
    public Type GetArrayType(Location location, Type elementType, int numElements)
        => gccjit.context_new_array_type(_context, location, elementType, numElements);

    public Param CreateParam(Location location, Type ty, string name) 
        => gccjit.context_new_param(_context, location, ty, name);

    public RValue ZeroFor(Type numericType)
        => gccjit.context_zero(_context, numericType);

    public RValue NewStringLiteral(string value) 
        => gccjit.context_new_string_literal(_context, value);

    public Function NewFunction(Location location, FunctionKind functionKind, Type returnType, string name,
        Param[] parameters, bool isVariadic)
    {
        var ps = new gcc_jit_param*[parameters.Length];
        for (var i = 0; i < parameters.Length; i++)
            ps[i] = parameters[i];
        
        fixed (gcc_jit_param** fps = ps)
        {
            return gccjit.context_new_function(_context, location, functionKind, returnType, name, parameters.Length, fps,
                isVariadic ? 1 : 0);
        }
        
    }

    public RValue NewCall(Location location, Function f, int numArgs, RValue[] args)
    {
        var rvalueArgs = new gcc_jit_rvalue*[args.Length];
        for (var i = 0; i < args.Length; i++)
            rvalueArgs[i] = args[i];
        
        fixed (gcc_jit_rvalue** arguments = rvalueArgs)
        {
            return gccjit.context_new_call(_context, location, f, numArgs, arguments);
        }
    }

    public Result Compile()
        => gccjit.context_compile(_context);

    public void CompileToFile(OutputKind kind, string filename)
        => gccjit.context_compile_to_file(_context, kind, filename);
    
    public void Release()
        => gccjit.context_release(_context);

    public static implicit operator gcc_jit_context*(Context c) => c._context;
}