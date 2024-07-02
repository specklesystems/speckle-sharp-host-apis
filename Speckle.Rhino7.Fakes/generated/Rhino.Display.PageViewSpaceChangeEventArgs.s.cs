namespace Rhino.Display;

public partial class PageViewSpaceChangeEventArgs : System.EventArgs
{
	public PageViewSpaceChangeEventArgs() {}
	public virtual Rhino.Display.RhinoPageView PageView
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid NewActiveDetailId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid OldActiveDetailId
	{
		get => throw new System.NotImplementedException();
	}
}
