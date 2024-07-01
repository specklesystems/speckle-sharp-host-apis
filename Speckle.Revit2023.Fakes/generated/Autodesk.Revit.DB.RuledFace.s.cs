namespace Autodesk.Revit.DB;

public partial class RuledFace : Autodesk.Revit.DB.Face
{
  public virtual Autodesk.Revit.DB.Curve get_Curve(System.Int32 index) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ get_Point(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Boolean IsExtruded
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean RulingsAreParallel
  {
    get => throw new System.NotImplementedException();
  }
}
