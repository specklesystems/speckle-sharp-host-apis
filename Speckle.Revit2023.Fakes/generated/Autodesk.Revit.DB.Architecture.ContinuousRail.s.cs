namespace Autodesk.Revit.DB.Architecture;

public partial class ContinuousRail : Autodesk.Revit.DB.Element
{
	public ContinuousRail() {}
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetPath() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetStartExtensionPath() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetEndExtensionPath() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetSupports() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId HostRailingId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Length
	{
		get => throw new System.NotImplementedException();
	}
}
