namespace Autodesk.Revit.DB.Analysis;

public partial class BuildingEnvelopeAnalyzer : System.IDisposable
{
	public BuildingEnvelopeAnalyzer() {}
	public static Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzer Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Analysis.BuildingEnvelopeAnalyzerOptions options) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.LinkElementId> GetBoundingElements() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.LinkElementId> GetBoundingElementsForSpaceVolume(System.Int32 spaceVolume) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetCenterPointsForConnectedGridCellsInSpaceVolume(System.Int32 spaceVolume) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
