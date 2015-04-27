/*### Problem 11. Version attribute
 * 
 * Create a `[Version]` attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format `major.minor` (e.g. `2.11`).
 * Apply the version attribute to a sample class and display its version at runtime.*/

using System;
using System.Reflection;


[assembly: AssemblyVersionAttribute("2.11")]

class TestClass
{
    static void Main()
    {
        Assembly assembl = typeof(TestClass).Assembly;

        AssemblyName assemblyName = assembl.GetName();
        Version version = assemblyName.Version;

        Console.WriteLine("This is version {0} of {1}.", version, assemblyName.Name);
    }
}
