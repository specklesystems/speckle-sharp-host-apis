namespace Autodesk.Revit.DB;

public partial class GroupType : Autodesk.Revit.DB.ElementType
{
  public GroupType() { }

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAvailableAttachedDetailGroupTypeIds() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.GroupSet Groups
  {
    get => throw new System.NotImplementedException();
  }
}
