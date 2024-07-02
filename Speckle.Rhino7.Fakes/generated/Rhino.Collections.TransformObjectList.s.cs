namespace Rhino.Collections;

public partial class TransformObjectList : System.IDisposable
{
	public TransformObjectList() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BoundingBox GetBoundingBox(System.Boolean regularObjects,System.Boolean grips) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateDisplayFeedbackTransform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual void Add(Rhino.DocObjects.RhinoObject rhinoObject) => throw new System.NotImplementedException();
	public virtual void Add(Rhino.DocObjects.ObjRef objref) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.RhinoObject ObjectArray() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.GripObject GripArray() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.RhinoObject GripOwnerArray() => throw new System.NotImplementedException();
	public virtual System.Boolean DisplayFeedbackEnabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Count
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
}
