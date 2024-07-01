namespace Autodesk.Revit.DB;

public partial class BaseArray : Autodesk.Revit.DB.Element
{
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetOriginalMemberIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetCopiedMemberIds() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter Label
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public new System.String Name
	{
		set {}
	}
	public virtual System.Int32 NumMembers
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
