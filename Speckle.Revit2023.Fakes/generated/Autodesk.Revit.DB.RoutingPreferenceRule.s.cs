namespace Autodesk.Revit.DB;

public partial class RoutingPreferenceRule : System.IDisposable
{
  public RoutingPreferenceRule(Autodesk.Revit.DB.ElementId MEPPartId, System.String description) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.RoutingCriterionBase GetCriterion(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual void AddCriterion(Autodesk.Revit.DB.RoutingCriterionBase myCriterion) =>
    throw new System.NotImplementedException();

  public virtual void RemoveCriteron(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.RoutingPreferenceManager RoutingPreferenceManager
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumberOfCriteria
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId MEPPartId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Description
  {
    get => throw new System.NotImplementedException();
  }
}
