namespace Autodesk.Revit.UI;

public partial class IFCExternalServiceUIData : System.Object
{
	public virtual System.IntPtr GetParentHwnd() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ElementId> GetRevitElementIds() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Document Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsReset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId ParamId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String SelectedIFCItem
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
