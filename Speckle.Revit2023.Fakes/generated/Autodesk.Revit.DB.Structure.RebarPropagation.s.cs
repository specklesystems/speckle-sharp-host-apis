namespace Autodesk.Revit.DB.Structure;

public partial class RebarPropagation
{
  public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> AlignByHost(
    Autodesk.Revit.DB.Document doc,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.Rebar> sourceRebars,
    Autodesk.Revit.DB.Element destinationHost
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> AlignByFace(
    Autodesk.Revit.DB.Document doc,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.Rebar> sourceRebars,
    Autodesk.Revit.DB.Reference sourceFaceReference,
    Autodesk.Revit.DB.Reference destinationFaceReference
  ) => throw new System.NotImplementedException();
}
