namespace Rhino.DocObjects;

public partial class Group : Rhino.DocObjects.ModelComponent
{
	public Group() {}
	public virtual System.Boolean SetUserString(System.String key,System.String value) => throw new System.NotImplementedException();
	public virtual System.String GetUserString(System.String key) => throw new System.NotImplementedException();
	public virtual System.Collections.Specialized.NameValueCollection GetUserStrings() => throw new System.NotImplementedException();
	public new Rhino.DocObjects.ModelComponentType ComponentType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 UserStringCount
	{
		get => throw new System.NotImplementedException();
	}
}
