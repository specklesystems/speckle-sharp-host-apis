namespace Autodesk.Revit.DB;

public partial class ElementType : Autodesk.Revit.DB.Element
{
  public virtual System.Boolean IsSimilarType(Autodesk.Revit.DB.ElementId typeId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetSimilarTypes() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementType Duplicate(System.String name) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidDefaultFamilyType(Autodesk.Revit.DB.ElementId familyCategoryId) =>
    throw new System.NotImplementedException();

  public virtual System.String FamilyName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CanBeDeleted
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CanBeRenamed
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CanBeCopied
  {
    get => throw new System.NotImplementedException();
  }
  public override System.String Name
  {
    set { }
  }
}
