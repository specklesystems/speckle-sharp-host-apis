namespace Rhino.Display;

public partial class CullObjectEventArgs : Rhino.Display.DrawEventArgs
{
	public CullObjectEventArgs() {}
	public virtual Rhino.DocObjects.RhinoObject RhinoObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.UInt32 RhinoObjectSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean CullObject
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
