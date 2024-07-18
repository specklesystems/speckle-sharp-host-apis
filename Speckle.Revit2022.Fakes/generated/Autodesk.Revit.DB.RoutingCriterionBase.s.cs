namespace Autodesk.Revit.DB;

public partial class RoutingCriterionBase : System.IDisposable
{
  public RoutingCriterionBase() { }

  public virtual System.Boolean IsEqual(Autodesk.Revit.DB.RoutingCriterionBase pOther) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
