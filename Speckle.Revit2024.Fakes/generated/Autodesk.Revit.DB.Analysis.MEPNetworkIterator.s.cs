namespace Autodesk.Revit.DB.Analysis;

public partial class MEPNetworkIterator : System.IDisposable
{
	public MEPNetworkIterator() {}
	public MEPNetworkIterator(Autodesk.Revit.DB.Document pADoc,Autodesk.Revit.DB.Analysis.MEPAnalyticalNode startNode,Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment startSegment) => throw new System.NotImplementedException();
	public MEPNetworkIterator(Autodesk.Revit.DB.Document pADoc,Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData seed,Autodesk.Revit.DB.ConnectorDomainType eDomain) => throw new System.NotImplementedException();
	public virtual void Start() => throw new System.NotImplementedException();
	public virtual System.Boolean End() => throw new System.NotImplementedException();
	public virtual void Next() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.MEPAnalyticalSegment GetAnalyticalSegment() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.MEPAnalyticalNode GetAnalyticalNode() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.MEPAnalyticalNode GetOtherAnalyticalNode() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.MEPAnalyticalModelData GetAnalyticalModelData() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId CurrentElementId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.MEPSystemClassification SystemClassification
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId SystemId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
