namespace Autodesk.Revit.UI;

public partial class ExternalEvent : System.Object
{
	public static Autodesk.Revit.UI.ExternalEvent Create(Autodesk.Revit.UI.IExternalEventHandler handler) => throw new System.NotImplementedException();
	public static Autodesk.Revit.UI.ExternalEvent CreateJournalable(Autodesk.Revit.UI.IExternalEventHandler handler) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.ExternalEventRequest Raise() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsPending
	{
		get => throw new System.NotImplementedException();
	}
}
