namespace Rhino.DocObjects;

public partial class BitmapEntry : Rhino.DocObjects.ModelComponent
{
	public BitmapEntry() {}
	public virtual System.Boolean Save(System.String fileName) => throw new System.NotImplementedException();
	public virtual System.String FileName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsReference
	{
		get => throw new System.NotImplementedException();
	}
	public new Rhino.DocObjects.ModelComponentType ComponentType
	{
		get => throw new System.NotImplementedException();
	}
}
