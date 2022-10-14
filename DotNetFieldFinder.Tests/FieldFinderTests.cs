using Mono.Cecil;
using NUnit.Framework;

namespace DotNetFieldFinder.Tests;

public class FieldFinderTests
{
    private AssemblyDefinition? _assembly;
    
    [SetUp]
    public void Setup()
    {
        _assembly = AssemblyDefinition.ReadAssembly("DotNetFieldFinder.TestAssembly.dll");
    }

    [Test]
    public void ReturnsTrueForAFieldThatDoesExist()
    { 
        Assert.True(FieldFinder.HasField(_assembly, "IntegerField"));
    }

    [Test]
    public void ReturnsFalseForAFieldThatDoesNotExist()
    {
        Assert.False(FieldFinder.HasField(_assembly, "FieldThatDoesNotExist"));
    }

    [Test]
    public void ReturnsTrueForAnotherFieldThatDoesExist()
    {
        Assert.True(FieldFinder.HasField(_assembly, "IntegerField2"));
    }
}