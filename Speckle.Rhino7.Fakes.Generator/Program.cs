using System.Reflection;
using Speckle.Shared;

var asm = Assembly.GetEntryAssembly().NotNull();
Assembly GetAssembly(string name)
{
  var path = Path.Combine("C:\\Users\\adam\\.nuget\\packages\\rhinocommon\\7.13.21348.13001\\lib\\net48", name);
  return Assembly.ReflectionOnlyLoadFrom(path);
}

Generator generator =
  new(
    "Speckle.Rhino7.Fakes",
    [GetAssembly("RhinoCommon.dll")],
    [
      "Rhino","Rhino.Geometry", "Rhino.Collections", "Rhino.Runtime","Rhino.DocObjects","Rhino.Commands","Rhino.Render"
    ],
    [
      new ("HostUtils", [new ("GetCustomComputeEndpoints")]),
      new ("LinearDimension", [new ("AnnotationType")]),
      new ("InstanceDefinition", [new ("ComponentType")]),
      new ("Polyline", [new ("Duplicate")]),
      new ("RadialDimension", [new ("AnnotationType")]),
      new ("MaterialRefs", [new ("CopyTo")]),
      new ("PersistentSettingsConverter", [new ("ToString")]),
      new ("PersistentSettings", [new ("GetStringDictionary"), new ("SetStringDictionary"), new ("SetDefault")]),
      new ("Dimension", [new ("TextFormula")]),
      new ("RunCommandDelegate", [])
    ]
  );
generator.Generate();
