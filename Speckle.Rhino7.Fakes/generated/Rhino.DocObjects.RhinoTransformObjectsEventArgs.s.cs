namespace Rhino.DocObjects;

public partial class RhinoTransformObjectsEventArgs : System.EventArgs
{
  public RhinoTransformObjectsEventArgs() { }

  public virtual Rhino.Geometry.Transform Transform
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean ObjectsWillBeCopied
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ObjectCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 GripCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 GripOwnerCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.RhinoObject[] Objects
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.GripObject[] Grips
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.RhinoObject[] GripOwners
  {
    get => throw new System.NotImplementedException();
  }
}
