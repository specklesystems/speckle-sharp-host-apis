namespace Rhino.DocObjects;

public partial class MaterialRef : System.IDisposable
{
	public MaterialRef() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.ObjectMaterialSource MaterialSource
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid PlugInId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid FrontFaceMaterialId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid BackFaceMaterialId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 FrontFaceMaterialIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 BackFaceMaterialIndex
	{
		get => throw new System.NotImplementedException();
	}
}
