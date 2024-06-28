namespace Autodesk.Revit.UI;

public partial class ExternalCommandData : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.DB.View View
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.UI.UIApplication Application
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
