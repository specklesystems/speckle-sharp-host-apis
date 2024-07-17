namespace Autodesk.Revit.DB;

public partial class Profile : Autodesk.Revit.DB.GeometryObject
{
  public Profile() { }

  public virtual Autodesk.Revit.DB.Profile get_Transformed(Autodesk.Revit.DB.Transform transform) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Profile Clone() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveArray Curves
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Filled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
