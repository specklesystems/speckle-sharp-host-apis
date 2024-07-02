namespace Rhino.Render;

public partial class RenderContentFieldChangedEventArgs : Rhino.Render.RenderContentChangedEventArgs
{
	public RenderContentFieldChangedEventArgs() {}
	public virtual System.String FieldName
	{
		get => throw new System.NotImplementedException();
	}
}
