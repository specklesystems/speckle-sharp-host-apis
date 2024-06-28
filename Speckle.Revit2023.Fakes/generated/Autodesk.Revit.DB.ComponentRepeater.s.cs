namespace Autodesk.Revit.DB;

public partial class ComponentRepeater : Autodesk.Revit.DB.Element
{
	public virtual System.Boolean IsTypeValidForRepeater(Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public static System.Boolean CanElementBeRepeated(Autodesk.Revit.DB.Document ADoc,Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public static IList<Autodesk.Revit.DB.ComponentRepeater> RepeatElements(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public static ISet<Autodesk.Revit.DB.ElementId> RemoveRepeaters(Autodesk.Revit.DB.Document document,ISet<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public virtual IEnumerator<Autodesk.Revit.DB.ComponentRepeaterSlot> GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 DimensionCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId DefaultFamilyType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
