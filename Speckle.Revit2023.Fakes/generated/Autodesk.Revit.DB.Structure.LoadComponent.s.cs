namespace Autodesk.Revit.DB.Structure;

public partial class LoadComponent : System.IDisposable
{
  public LoadComponent(Autodesk.Revit.DB.ElementId loadCaseOrCombinationId, System.Double factor) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Factor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId LoadCaseOrCombinationId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
