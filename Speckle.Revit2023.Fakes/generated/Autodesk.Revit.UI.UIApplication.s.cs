namespace Autodesk.Revit.UI;

public partial class UIApplication : System.Object
{
				public virtual void PostCommand(Autodesk.Revit.UI.RevitCommandId commandId) => throw new System.NotImplementedException();
									public virtual Autodesk.Revit.DB.AddInId get_ActiveAddInId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.AddInCommandBinding CreateAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId revitCommandId) => throw new System.NotImplementedException();
	public virtual void RemoveAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId revitCommandId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.DockablePane GetDockablePane(Autodesk.Revit.UI.DockablePaneId id) => throw new System.NotImplementedException();
		}
