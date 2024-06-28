namespace Autodesk.Revit.UI;

public partial class IExternalEventHandler
{
	public virtual void Execute(Autodesk.Revit.UI.UIApplication app) => throw new System.NotImplementedException();
	public virtual System.String GetName() => throw new System.NotImplementedException();
}
