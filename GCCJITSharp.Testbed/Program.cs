using GCCJITSharp.Interop;

var context = Context.Create();
var defaultLocation = Location.Create(context, "foo", 0, 0);
var voidType = context.GetType(Types.GCC_JIT_TYPE_VOID);
var constCharPointerType = context.GetType(Types.GCC_JIT_TYPE_CONST_CHAR_PTR);
var intType = context.GetType(Types.GCC_JIT_TYPE_INT);

var nameParam = context.CreateParam(defaultLocation, constCharPointerType, "name");
var func = context.NewFunction(
    defaultLocation,
    FunctionKind.GCC_JIT_FUNCTION_EXPORTED,
    voidType,
    "greet",
    new[] { nameParam },
    false
);

var formatParam = context.CreateParam(defaultLocation, constCharPointerType, "format");
var printFFunc = context.NewFunction(
    defaultLocation,
    FunctionKind.GCC_JIT_FUNCTION_IMPORTED,
    intType,
    "printf",
    new [] { formatParam },
    true
);

var argZero = context.NewStringLiteral("hello %s\n");
var argOne = nameParam.AsRValue();

var block = func.CreateBlock(null);

block.AddEval(
    defaultLocation,
    context.NewCall(
        defaultLocation,
        printFFunc,
        2,
        new [] { argZero, argOne }
    )
);

block.EndWithVoidReturn(defaultLocation);

context.SetBoolOption(BoolOption.GCC_JIT_BOOL_OPTION_DUMP_GENERATED_CODE, 1);

var charPointerPointerType = context.GetType(Types.GCC_JIT_TYPE_CHAR).GetPointer().GetPointer();

var argcParam = context.CreateParam(defaultLocation, intType, "argc");
var argvParam = context.CreateParam(defaultLocation, charPointerPointerType, "argv");
var mainFunc = context.NewFunction(
    defaultLocation,
    FunctionKind.GCC_JIT_FUNCTION_EXPORTED,
    intType,
    "main",
    new [] { argcParam, argvParam },
    false
);

var mainFuncBlock = mainFunc.CreateBlock(null);
mainFuncBlock.AddEval(defaultLocation, context.NewCall(defaultLocation, func, 1, [context.NewStringLiteral("rika")]));
mainFuncBlock.EndWithReturn(defaultLocation, context.ZeroFor(intType));

context.CompileToFile(OutputKind.GCC_JIT_OUTPUT_KIND_ASSEMBLER, "greet.S");
context.Release();