namespace Autodesk.Revit.DB.Mechanical;

public partial class MechanicalEquipmentSet : Autodesk.Revit.DB.Element
{
	public MechanicalEquipmentSet() {}
	public static Autodesk.Revit.DB.Mechanical.MechanicalEquipmentSet Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId typeId,System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> memberIds) => throw new System.NotImplementedException();
	public static System.Boolean AreElementsNotConnectedInSeries(Autodesk.Revit.DB.Document document,System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> elemIds) => throw new System.NotImplementedException();
	public static System.Boolean AreValidMembers(Autodesk.Revit.DB.Document document,System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> memberIds) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetMembers() => throw new System.NotImplementedException();
	public virtual void Add(System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> elemIds) => throw new System.NotImplementedException();
	public virtual void Remove(System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> elemIds) => throw new System.NotImplementedException();
	public virtual System.Int32 OnStandby
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 OnDuty
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Mechanical.EquipmentClassification Classification
	{
		get => throw new System.NotImplementedException();
	}
}
