namespace Autodesk.Revit.DB.Electrical;

public partial class CableTrayType : Autodesk.Revit.DB.MEPCurveType
{
  public CableTrayType() { }

  public virtual System.Boolean IsValidBendMultiplier(System.Double bendMultiplier) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsWithFitting
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Electrical.CableTrayShape ShapeType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double BendMultiplier
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
