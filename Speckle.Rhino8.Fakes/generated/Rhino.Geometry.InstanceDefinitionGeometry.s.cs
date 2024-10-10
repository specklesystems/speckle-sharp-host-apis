namespace Rhino.Geometry;

public partial class InstanceDefinitionGeometry : Rhino.DocObjects.ModelComponent
{
  public InstanceDefinitionGeometry() { }

  public virtual System.Guid[] GetObjectIds() => throw new System.NotImplementedException();

  public virtual System.Boolean SetUserString(System.String key, System.String value) =>
    throw new System.NotImplementedException();

  public virtual System.String GetUserString(System.String key) => throw new System.NotImplementedException();

  public virtual System.Collections.Specialized.NameValueCollection GetUserStrings() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean DeleteUserString(System.String key) => throw new System.NotImplementedException();

  public virtual void DeleteAllUserStrings() => throw new System.NotImplementedException();

  public virtual System.String Description
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Url
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String UrlDescription
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String SourceArchive
  {
    get => throw new System.NotImplementedException();
  }
  public new Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 UserStringCount
  {
    get => throw new System.NotImplementedException();
  }
}
