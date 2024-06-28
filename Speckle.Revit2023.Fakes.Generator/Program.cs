using System.Reflection;
using Speckle.Shared;

var asm = Assembly.GetEntryAssembly();
var path = Path.Combine(Path.GetDirectoryName(asm.Location), ("RevitAPI.dll"));
Generator generator = new("Speckle.Revit2023.Fakes", Assembly.ReflectionOnlyLoadFrom(path), ["Autodesk.Revit.DB", "Autodesk.Revit.DB.Architecture"]);
generator.Generate();
