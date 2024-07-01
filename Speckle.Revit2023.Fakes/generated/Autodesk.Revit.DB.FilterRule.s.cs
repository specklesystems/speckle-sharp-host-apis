namespace Autodesk.Revit.DB;

public partial class FilterRule : System.IDisposable
{
  public virtual System.Boolean ElementPasses(Autodesk.Revit.DB.Element element) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetRuleParameter() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
