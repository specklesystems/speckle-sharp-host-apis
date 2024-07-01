namespace Autodesk.Revit.DB;

public partial class ClassificationEntry : Autodesk.Revit.DB.KeyBasedTreeEntry
{
  public ClassificationEntry(
    System.String key,
    System.String parentKey,
    System.String description,
    System.Int32 level,
    Autodesk.Revit.DB.ElementId categoryId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean HasBadLevel() => throw new System.NotImplementedException();

  public virtual System.Boolean HasBadCategoryId() => throw new System.NotImplementedException();

  public virtual System.Boolean HasInvalidKey() => throw new System.NotImplementedException();

  public virtual System.String Description
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId CategoryId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Level
  {
    get => throw new System.NotImplementedException();
  }
}
