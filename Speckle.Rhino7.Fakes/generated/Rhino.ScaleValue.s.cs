namespace Rhino;

public partial class ScaleValue : System.IDisposable
{
	public ScaleValue() {}
	public static Rhino.ScaleValue OneToOne() => throw new System.NotImplementedException();
	public static Rhino.ScaleValue Create(Rhino.LengthValue left,Rhino.LengthValue right,Rhino.ScaleValue.ScaleStringFormat format) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsUnset() => throw new System.NotImplementedException();
	public virtual Rhino.LengthValue LeftLengthValue() => throw new System.NotImplementedException();
	public virtual Rhino.LengthValue RightLengthValue() => throw new System.NotImplementedException();
	public virtual System.Double LeftToRightScale
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double RightToLeftScale
	{
		get => throw new System.NotImplementedException();
	}
}
