namespace Autodesk.Revit.UI;

public partial class UIControlledApplication
{
	public UIControlledApplication() {}
	public virtual void CreateRibbonTab(System.String tabName) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.RibbonPanel CreateRibbonPanel(Autodesk.Revit.UI.Tab tab,System.String panelName) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.RibbonPanel CreateRibbonPanel(System.String panelName) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.RibbonPanel CreateRibbonPanel(System.String tabName,System.String panelName) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.List<Autodesk.Revit.UI.RibbonPanel> GetRibbonPanels(System.String tabName) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.List<Autodesk.Revit.UI.RibbonPanel> GetRibbonPanels(Autodesk.Revit.UI.Tab tab) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.List<Autodesk.Revit.UI.RibbonPanel> GetRibbonPanels() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.AddInCommandBinding CreateAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId revitCommandId) => throw new System.NotImplementedException();
	public virtual void RemoveAddInCommandBinding(Autodesk.Revit.UI.RevitCommandId revitCommandId) => throw new System.NotImplementedException();
	public virtual void LoadAddIn(System.String fileName) => throw new System.NotImplementedException();
	public virtual void LoadPackageContents(System.String packageContentsPath) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.DockablePane GetDockablePane(Autodesk.Revit.UI.DockablePaneId id) => throw new System.NotImplementedException();
	public virtual void RegisterDockablePane(Autodesk.Revit.UI.DockablePaneId id,System.String title,Autodesk.Revit.UI.IDockablePaneProvider provider) => throw new System.NotImplementedException();
	public virtual System.IntPtr MainWindowHandle
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ProductIsRS
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.AddInId ActiveAddInId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.UI.ExternalApplicationArray LoadedApplications
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsViewerModeActive
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsLateAddinLoading
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.ApplicationServices.ControlledApplication ControlledApplication
	{
		get => throw new System.NotImplementedException();
	}
}
