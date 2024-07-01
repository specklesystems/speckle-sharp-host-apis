using System.Reflection;
using Speckle.Shared;

var asm = Assembly.GetEntryAssembly();
Assembly GetAssembly(string name)
{
  var path = Path.Combine(Path.GetDirectoryName(asm.Location), name);
  return Assembly.ReflectionOnlyLoadFrom(path);
}

Generator generator = new("Speckle.Revit2023.Fakes", [GetAssembly("RevitAPI.dll"), 
  GetAssembly("RevitAPIUI.dll")], 
  ["Autodesk.Revit.DB", "Autodesk.Revit.DB.Architecture", "Autodesk.Revit.UI", "Autodesk.Revit.DB.ExtensibleStorage"],
  [
    new ("WallSweepInfo", []),
    new ("ProjectInfo", [new ("Name")]), 
    new ("ImageView", [new ("Create")])]);
generator.Generate();
