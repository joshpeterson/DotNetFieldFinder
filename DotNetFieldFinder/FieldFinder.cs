using System.Runtime.CompilerServices;
using Mono.Cecil;

namespace DotNetFieldFinder;

public static class FieldFinder
{
    public static bool HasField(AssemblyDefinition? assembly, string fieldName)
    {
        if (assembly != null)
        {
            foreach (var type in assembly.MainModule.Types)
            {
                foreach (var field in type.Fields)
                {
                    if (field.Name == fieldName && !field.IsStatic)
                        return true;
                }
            }
        }

        return false;
    }
}