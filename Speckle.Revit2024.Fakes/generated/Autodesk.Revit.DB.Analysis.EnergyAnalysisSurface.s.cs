namespace Autodesk.Revit.DB.Analysis;

public partial class EnergyAnalysisSurface : Autodesk.Revit.DB.Element
{
	public EnergyAnalysisSurface() {}
	public virtual Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace GetAnalyticalSpace() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace GetAdjacentAnalyticalSpace() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening> GetAnalyticalOpenings() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.EnergyAnalysisConstruction GetConstruction() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.Polyloop GetPolyloop() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.Polyloop> GetPolyloops() => throw new System.NotImplementedException();
	public virtual System.String SurfaceId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Corner
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Normal
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Analysis.EnergyAnalysisSurfaceType SurfaceType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String OriginatingElementName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String OriginatingElementDescription
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String CADLinkUniqueId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String CADObjectUniqueId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.LinkElementId OriginatingElementId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String SurfaceName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Analysis.gbXMLSurfaceType Type
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Tilt
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Azimuth
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Height
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Width
	{
		get => throw new System.NotImplementedException();
	}
}
