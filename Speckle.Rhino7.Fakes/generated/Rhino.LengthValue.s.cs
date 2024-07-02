namespace Rhino;

public partial class LengthValue : System.IDisposable
{
	public LengthValue() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public static Rhino.LengthValue Create(System.Double length,Rhino.UnitSystem us,Rhino.LengthValue.StringFormat format) => throw new System.NotImplementedException();
	public static Rhino.LengthValue Create(System.Double length,Rhino.UnitSystem us,Rhino.LengthValue.StringFormat format,System.UInt32 localeId) => throw new System.NotImplementedException();
	public virtual System.Double Length() => throw new System.NotImplementedException();
	public virtual System.Double Length(Rhino.UnitSystem units) => throw new System.NotImplementedException();
	public virtual Rhino.LengthValue ChangeLength(System.Double newLength) => throw new System.NotImplementedException();
	public virtual Rhino.LengthValue ChangeUnitSystem(Rhino.UnitSystem newUnits) => throw new System.NotImplementedException();
	public virtual System.Boolean IsUnset() => throw new System.NotImplementedException();
	public virtual System.String LengthString
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.UnitSystem UnitSystem
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.LengthValue.StringFormat LengthStringFormat
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.UInt32 ContextLocaleId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.AngleUnitSystem ContextAngleUnitSystem
	{
		get => throw new System.NotImplementedException();
	}
}
