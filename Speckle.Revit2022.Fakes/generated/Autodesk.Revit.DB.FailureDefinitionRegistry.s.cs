namespace Autodesk.Revit.DB;

public partial class FailureDefinitionRegistry : System.IDisposable
{
  public FailureDefinitionRegistry() { }

  public virtual Autodesk.Revit.DB.FailureDefinitionAccessor FindFailureDefinition(
    Autodesk.Revit.DB.FailureDefinitionId id
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FailureDefinitionAccessor> ListAllFailureDefinitions() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
