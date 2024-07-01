namespace Autodesk.Revit.DB;

public partial class DisplacementPath : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.ElementId Create(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.DisplacementElement displacementElement,
    Autodesk.Revit.DB.Reference reference,
    System.Double param
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidParam(System.Double param) => throw new System.NotImplementedException();

  public static System.Boolean IsValidReference(
    Autodesk.Revit.DB.DisplacementElement displacementElement,
    Autodesk.Revit.DB.Reference reference
  ) => throw new System.NotImplementedException();

  public virtual void SetAnchorPoint(
    Autodesk.Revit.DB.DisplacementElement displacementElement,
    Autodesk.Revit.DB.Reference reference,
    System.Double param
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DisplacementPathStyle PathStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 AncestorIdx
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
