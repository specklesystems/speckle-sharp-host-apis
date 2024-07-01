namespace Autodesk.Revit.DB;

public partial class PointOnPlane : Autodesk.Revit.DB.PointElementReference
{
  public static Autodesk.Revit.DB.PointOnPlane NewPointOnPlane(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.Reference planeReference,
    Autodesk.Revit.DB.XYZ position,
    Autodesk.Revit.DB.XYZ xvec
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetPlaneReference() => throw new System.NotImplementedException();

  public virtual void SetPlaneReference(Autodesk.Revit.DB.Reference planeReference) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidPlaneReference(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.Reference planeReference
  ) => throw new System.NotImplementedException();

  public virtual System.Double Offset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.UV XVec
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.UV Position
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
