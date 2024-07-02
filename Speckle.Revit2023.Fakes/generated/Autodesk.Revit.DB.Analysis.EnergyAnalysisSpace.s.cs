namespace Autodesk.Revit.DB.Analysis;

public partial class EnergyAnalysisSpace : Autodesk.Revit.DB.Element
{
	public EnergyAnalysisSpace() {}
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface> GetAnalyticalSurfaces() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.Polyloop> GetClosedShell() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.Polyloop> GetBoundary() => throw new System.NotImplementedException();
	public virtual System.Double Volume
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Area
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String CADObjectUniqueId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String ComposedName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Description
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String SpaceName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double InnerVolume
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double AnalyticalVolume
	{
		get => throw new System.NotImplementedException();
	}
}
