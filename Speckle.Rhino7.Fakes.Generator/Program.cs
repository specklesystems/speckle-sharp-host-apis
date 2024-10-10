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
      "Rhino",
      "Rhino.Geometry",
      "Rhino.Collections",
      "Rhino.Runtime",
      "Rhino.DocObjects",
      "Rhino.Commands",
      "Rhino.Render",
      "Rhino.Display",
      "Rhino.Geometry.Collections",
      "Rhino.FileIO"
    ],
    [
      new("HostUtils", [new("GetCustomComputeEndpoints")]),
      new("LinearDimension", [new("AnnotationType")]),
      new("InstanceDefinition", [new("ComponentType")]),
      new("Polyline", [new("Duplicate"), new("System.ICloneable.Clone")]),
      new("RadialDimension", [new("AnnotationType")]),
      new("MaterialRefs", [new("CopyTo")]),
      new("PersistentSettingsConverter", [new("TryParseStringDictionary"), new("ToString")]),
      new(
        "PersistentSettings",
        [new("TryGetStringDictionary"), new("GetStringDictionary"), new("SetStringDictionary"), new("SetDefault")]
      ),
      new("Dimension", [new("TextFormula")]),
      new("CreatePreviewEventArgs", [new("Objects")]),
      new("RunCommandDelegate", []),
      new("ArchivableDictionary", []),
      new("RenderMaterial", [new("HandleTexturedValue")]),
      new("CustomRenderMeshProvider2", [new("BoundingBox")]),
      new("Color4f", [new("GetObjectData")]),
      new("Point3dList", [new("Duplicate"), new("System.ICloneable.Clone")]),
      new("File3dmCommonComponentTable`1", [new("System.Collections.Generic.ICollection<T>.Add")]),
    ]
  );
generator.Generate();
