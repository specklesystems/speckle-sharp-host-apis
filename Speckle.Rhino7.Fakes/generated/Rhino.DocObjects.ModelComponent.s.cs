namespace Rhino.DocObjects;

public partial class ModelComponent : Rhino.Runtime.CommonObject
{
  public ModelComponent() { }

  public virtual System.UInt32 DataCRC(System.UInt32 currentRemainder) => throw new System.NotImplementedException();

  public virtual void ClearId() => throw new System.NotImplementedException();

  public virtual void LockId() => throw new System.NotImplementedException();

  public virtual void ClearIndex() => throw new System.NotImplementedException();

  public virtual void LockIndex() => throw new System.NotImplementedException();

  public static System.Boolean IsValidComponentName(System.String name) => throw new System.NotImplementedException();

  public virtual void ClearName() => throw new System.NotImplementedException();

  public virtual void LockName() => throw new System.NotImplementedException();

  public static System.Boolean ModelComponentTypeRequiresUniqueName(Rhino.DocObjects.ModelComponentType type) =>
    throw new System.NotImplementedException();

  public static System.Boolean ModelComponentTypeIgnoresCase(Rhino.DocObjects.ModelComponentType type) =>
    throw new System.NotImplementedException();

  public static System.Boolean ModelComponentTypeIncludesParent(Rhino.DocObjects.ModelComponentType type) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSystemComponent
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid Id
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean HasId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IdIsLocked
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Index
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean HasIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IndexIsLocked
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.ComponentStatus ComponentStatus
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsComponentStatusLocked
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean HasName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean NameIsLocked
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String DeletedName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.UInt32 ModelSerialNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.UInt32 ReferenceModelSerialNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.UInt32 InstanceDefinitionModelSerialNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
}
