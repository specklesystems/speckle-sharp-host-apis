namespace Autodesk.Revit.DB;

public partial class AssemblyInstance : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.AssemblyInstance Create(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.ElementId> assemblyMemberIds,Autodesk.Revit.DB.ElementId namingCategoryId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.AssemblyInstance PlaceInstance(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId assemblyTypeId,Autodesk.Revit.DB.XYZ location) => throw new System.NotImplementedException();
	public static System.Boolean AreElementsValidForAssembly(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.ElementId> assemblyMemberIds,Autodesk.Revit.DB.ElementId assemblyId) => throw new System.NotImplementedException();
	public static System.Boolean CanRemoveElementsFromAssembly(Autodesk.Revit.DB.AssemblyInstance assemblyInstance,ICollection<Autodesk.Revit.DB.ElementId> memberIds) => throw new System.NotImplementedException();
	public static System.Boolean IsValidNamingCategory(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId namingCategoryId,ICollection<Autodesk.Revit.DB.ElementId> assemblyMemberIds) => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetMemberIds() => throw new System.NotImplementedException();
	public virtual void SetMemberIds(ICollection<Autodesk.Revit.DB.ElementId> memberIds) => throw new System.NotImplementedException();
	public virtual void AddMemberIds(ICollection<Autodesk.Revit.DB.ElementId> memberIds) => throw new System.NotImplementedException();
	public virtual void RemoveMemberIds(ICollection<Autodesk.Revit.DB.ElementId> memberIds) => throw new System.NotImplementedException();
	public virtual System.Boolean IsMember(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual System.Boolean AllowsAssemblyViewCreation() => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> Disassemble() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.AssemblyDifference CompareAssemblyInstances(Autodesk.Revit.DB.AssemblyInstance instance1,Autodesk.Revit.DB.AssemblyInstance instance2) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetCenter() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetTransform() => throw new System.NotImplementedException();
	public virtual void SetTransform(Autodesk.Revit.DB.Transform trf) => throw new System.NotImplementedException();
	public virtual System.String AssemblyTypeName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId NamingCategoryId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public new Autodesk.Revit.DB.Location Location
	{
		get => throw new System.NotImplementedException();
	}
}
