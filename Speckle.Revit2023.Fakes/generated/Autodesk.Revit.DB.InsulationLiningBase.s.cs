namespace Autodesk.Revit.DB;

public partial class InsulationLiningBase : Autodesk.Revit.DB.MEPCurve
{
	public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetInsulationIds(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId elemId) => throw new System.NotImplementedException();
	public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetLiningIds(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId elemId) => throw new System.NotImplementedException();
	public static System.Boolean IsValidThickness(System.Double thickness) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId HostElementId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Thickness
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
