namespace Autodesk.Revit.DB;

public partial class Group : Autodesk.Revit.DB.Element
{
  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> UngroupMembers() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetMemberIds() =>
    throw new System.NotImplementedException();

  public virtual void ShowAttachedDetailGroups(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.ElementId detailGroupTypeId
  ) => throw new System.NotImplementedException();

  public virtual void ShowAllAttachedDetailGroups(Autodesk.Revit.DB.View view) =>
    throw new System.NotImplementedException();

  public virtual void HideAttachedDetailGroups(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.ElementId detailGroupTypeId
  ) => throw new System.NotImplementedException();

  public virtual void HideAllAttachedDetailGroups(Autodesk.Revit.DB.View view) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetShownAttachedDetailGroupTypeIds(
    Autodesk.Revit.DB.View view
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAvailableAttachedDetailGroupTypeIds() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsCompatibleAttachedDetailGroupType(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.ElementId detailGroupTypeId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId AttachedParentId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsAttached
  {
    get => throw new System.NotImplementedException();
  }
  public new Autodesk.Revit.DB.Location Location
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.GroupType GroupType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
