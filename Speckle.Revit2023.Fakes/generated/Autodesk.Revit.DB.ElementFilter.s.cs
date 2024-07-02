namespace Autodesk.Revit.DB;

public partial class ElementFilter : System.IDisposable
{
	public ElementFilter() {}
	public virtual System.Boolean PassesFilter(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual System.Boolean PassesFilter(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Inverted
	{
		get => throw new System.NotImplementedException();
	}
}
