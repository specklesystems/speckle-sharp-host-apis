namespace Rhino.Geometry;

public partial class HermiteSurface : System.IDisposable
{
	public HermiteSurface() {}
	public HermiteSurface(System.Int32 uCount,System.Int32 vCount) => throw new System.NotImplementedException();
	public virtual System.Double UParameterAt(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void SetUParameterAt(System.Int32 index,System.Double parameter) => throw new System.NotImplementedException();
	public virtual System.Double VParameterAt(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void SetVParameterAt(System.Int32 index,System.Double parameter) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d PointAt(System.Int32 uIndex,System.Int32 vIndex) => throw new System.NotImplementedException();
	public virtual void SetPointAt(System.Int32 uIndex,System.Int32 vIndex,Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d UTangentAt(System.Int32 uIndex,System.Int32 vIndex) => throw new System.NotImplementedException();
	public virtual void SetUTangentAt(System.Int32 uIndex,System.Int32 vIndex,Rhino.Geometry.Vector3d tangent) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d VTangentAt(System.Int32 uIndex,System.Int32 vIndex) => throw new System.NotImplementedException();
	public virtual void SetVTangentAt(System.Int32 uIndex,System.Int32 vIndex,Rhino.Geometry.Vector3d tangent) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d TwistAt(System.Int32 uIndex,System.Int32 vIndex) => throw new System.NotImplementedException();
	public virtual void SetTwistAt(System.Int32 uIndex,System.Int32 vIndex,Rhino.Geometry.Vector3d twist) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsSurface ToNurbsSurface() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 UCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 VCount
	{
		get => throw new System.NotImplementedException();
	}
}
