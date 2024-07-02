namespace Autodesk.Revit.DB;

public partial class DefinitionGroups
  : System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.DefinitionGroup>,
    System.Collections.IEnumerable,
    System.IDisposable
{
  public DefinitionGroups() { }

  public virtual Autodesk.Revit.DB.DefinitionGroup get_Item(System.String groupName) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DefinitionGroup Create(System.String name) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Autodesk.Revit.DB.DefinitionGroup definitionGroup) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.DefinitionGroup> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Int32 Size
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsEmpty
  {
    get => throw new System.NotImplementedException();
  }
}
