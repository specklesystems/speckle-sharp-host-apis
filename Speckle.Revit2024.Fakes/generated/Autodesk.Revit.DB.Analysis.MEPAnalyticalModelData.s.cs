namespace Autodesk.Revit.DB.Analysis;

public partial class MEPAnalyticalModelData : System.IDisposable
{
	public MEPAnalyticalModelData() {}
	public virtual Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment GetSegmentById(System.Int32 segmentId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment GetSegmentByIndex(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidSegmentId(System.Int32 segmentId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.MEPNetworkSegmentData GetSegmentData(System.Int32 segmentId) => throw new System.NotImplementedException();
	public virtual System.Int32 GetNumberOfNodes() => throw new System.NotImplementedException();
	public virtual System.Int32 GetNumberOfSegments() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.MEPAnalyticalNode GetNodeById(System.Int32 nodeId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidNodeId(System.Int32 nodeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.MEPAnalyticalNode GetNodeByIndex(System.Int32 index) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData GetMEPAnalyticalModelData(Autodesk.Revit.DB.Element pElement) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
