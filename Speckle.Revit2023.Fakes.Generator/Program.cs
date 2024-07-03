using System.Reflection;
using Speckle.Shared;

var asm = Assembly.GetEntryAssembly();
Assembly GetAssembly(string name)
{
  var path = Path.Combine(Path.GetDirectoryName(asm.Location), name);
  return Assembly.ReflectionOnlyLoadFrom(path);
}

Generator generator =
  new(
    "Speckle.Revit2023.Fakes",
    [GetAssembly("RevitAPI.dll"), GetAssembly("RevitAPIUI.dll")],
    [
      "Autodesk.Revit.DB",
      "Autodesk.Revit.DB.Architecture",
      "Autodesk.Revit.ApplicationServices",
      "Autodesk.Revit.Creation",
      "Autodesk.Revit.UI",
      "Autodesk.Revit.DB.ExtensibleStorage",
      "Autodesk.Revit.DB.ExternalService",
      "Autodesk.Revit.DB.Structure",
      "Autodesk.Revit.DB.Electrical",
      "Autodesk.Revit.DB.Plumbing",
      "Autodesk.Revit.DB.Fabrication",
      "Autodesk.Revit.DB.Mechanical",
      "Autodesk.Revit.DB.Analysis",
      "Autodesk.Revit.DB.PointClouds",
      "Autodesk.Revit.Exceptions"
    ],
    [
      new("WallSweepInfo", []),
      new("ToggleButtonData", []),
      new("RadioButtonGroup", []),
      new("PanelScheduleTemplate", [new("IsValidType")]),
      new("FabricReinSpanSymbol", [new("Create")]),
      new("PathReinSpanSymbol", [new("Create")]),
      new("RebarSystemSpanSymbol", [new("Create")]),
      new("ProjectInfo", [new("Name")]),
      new("Dimension", [new("Name")]),
      new("ReferencePlane", [new("Name")]),
      new("ImageView", [new("Create")])
    ],
    GeneratorOptions.ExplicitProperties
  );
generator.Generate();
