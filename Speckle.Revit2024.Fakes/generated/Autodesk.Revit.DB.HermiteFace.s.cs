namespace Autodesk.Revit.DB;

public partial class HermiteFace : Autodesk.Revit.DB.Face
{
  public HermiteFace() { }

  public virtual Autodesk.Revit.DB.DoubleArray get_Params(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> get_Tangents(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> MixedDerivs
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> Points
  {
    get => throw new System.NotImplementedException();
  }
}
