namespace Autodesk.Revit.DB;

public partial class PolyLine : Autodesk.Revit.DB.GeometryObject
{
  public PolyLine() { }

  public virtual Autodesk.Revit.DB.XYZ Evaluate(System.Double param) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ GetCoordinate(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetCoordinates() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Outline GetOutline() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PolyLine GetTransformed(Autodesk.Revit.DB.Transform transform) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PolyLine Clone() => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.PolyLine Create(
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> coordinates
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 NumberOfCoordinates
  {
    get => throw new System.NotImplementedException();
  }
}
