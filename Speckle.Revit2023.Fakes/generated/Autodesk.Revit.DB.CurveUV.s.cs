namespace Autodesk.Revit.DB;

public partial class CurveUV : System.IDisposable
{
	public static Autodesk.Revit.DB.CurveUV Create(Autodesk.Revit.DB.Curve curve3D) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve As3DCurveInXYPlane() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV Evaluate(System.Double parameter,System.Boolean normalized) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.UV> ComputeDerivatives(System.Double parameter,System.Boolean normalized) => throw new System.NotImplementedException();
	public virtual System.Double GetEndParameter(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveUV Transform(Autodesk.Revit.DB.Transform2D trfUV) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsBound
	{
		get => throw new System.NotImplementedException();
	}
}
