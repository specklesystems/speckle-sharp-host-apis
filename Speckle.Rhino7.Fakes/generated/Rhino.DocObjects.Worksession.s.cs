namespace Rhino.DocObjects;

public partial class Worksession
{
	public Worksession() {}
	public static System.String FileNameFromRuntimeSerialNumber(System.UInt32 runtimeSerialNumber) => throw new System.NotImplementedException();
	public virtual System.String ModelPathFromSerialNumber(System.UInt32 modelSerialNumber) => throw new System.NotImplementedException();
	public virtual Rhino.RhinoDoc Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.UInt32 RuntimeSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String FileName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 ModelCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String[] ModelPaths
	{
		get => throw new System.NotImplementedException();
	}
}
