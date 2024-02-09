using System.Text;

namespace GCCJITSharp.Interop;

public unsafe class Location(gcc_jit_location* location)
{
    private gcc_jit_location* _location = location;

    public static Location Create(Context c, string fileName, int line, int column)
    {
        var loc = gccjit.context_new_location(c, fileName, line, column);
        return new Location(loc);
    }

    public static implicit operator gcc_jit_location*(Location l) => l._location;
}