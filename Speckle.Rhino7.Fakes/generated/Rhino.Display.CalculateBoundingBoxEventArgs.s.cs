namespace Rhino.Display;

public partial class CalculateBoundingBoxEventArgs : Rhino.Display.DrawEventArgs
{
	public CalculateBoundingBoxEventArgs() {}
	public virtual void IncludeBoundingBox(Rhino.Geometry.BoundingBox box) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BoundingBox BoundingBox
	{
		get => throw new System.NotImplementedException();
	}
}
