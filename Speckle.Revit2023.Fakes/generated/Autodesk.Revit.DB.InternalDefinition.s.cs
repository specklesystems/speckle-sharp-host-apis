namespace Autodesk.Revit.DB;

public partial class InternalDefinition : Autodesk.Revit.DB.Definition, System.IDisposable
{
  public InternalDefinition() { }

  public virtual void SetGroupTypeId(Autodesk.Revit.DB.ForgeTypeId groupTypeId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ForgeTypeId GetParameterTypeId() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ForgeTypeId GetTypeId() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> SetAllowVaryBetweenGroups(
    Autodesk.Revit.DB.Document document,
    System.Boolean allowVaryBetweenGroups
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId Id
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean VariesAcrossGroups
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Visible
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.BuiltInParameter BuiltInParameter
  {
    get => throw new System.NotImplementedException();
  }
  public new Autodesk.Revit.DB.BuiltInParameterGroup ParameterGroup
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public new System.String Name
  {
    get => throw new System.NotImplementedException();
  }
}
