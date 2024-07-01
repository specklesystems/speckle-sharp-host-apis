namespace Autodesk.Revit.DB;

public partial class FilteredWorksetIterator : IEnumerator<Autodesk.Revit.DB.Workset>
{
	public virtual Autodesk.Revit.DB.Workset GetCurrent() => throw new System.NotImplementedException();
	public virtual System.Boolean MoveNext() => throw new System.NotImplementedException();
	public virtual System.Boolean IsDone() => throw new System.NotImplementedException();
	public virtual void Reset() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Workset Current
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
