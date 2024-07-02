namespace Rhino.DocObjects;

public partial class ReplayHistoryData : System.IDisposable
{
	public ReplayHistoryData() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.ObjRef GetRhinoObjRef(System.Int32 id) => throw new System.NotImplementedException();
	public virtual Rhino.RhinoDoc Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 HistoryVersion
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid RecordId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.ReplayHistoryResult[] Results
	{
		get => throw new System.NotImplementedException();
	}
}
