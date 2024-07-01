namespace Autodesk.Revit.DB;

public partial class Transform1D : System.Object
{
	public Transform1D(System.Double scale) => throw new System.NotImplementedException();
	public Transform1D(System.Double scale,System.Double translation) => throw new System.NotImplementedException();
	public Transform1D(Autodesk.Revit.DB.Transform1D other) => throw new System.NotImplementedException();
	public virtual System.Boolean AlmostEqual(Autodesk.Revit.DB.Transform1D right) => throw new System.NotImplementedException();
	public virtual void Assign(Autodesk.Revit.DB.Transform1D from) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform1D SetToIdentity() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform1D Multiply(Autodesk.Revit.DB.Transform1D right) => throw new System.NotImplementedException();
	public virtual System.Double OfPoint(System.Double point) => throw new System.NotImplementedException();
	public virtual System.Double OfVector(System.Double vector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform1D GetInverse() => throw new System.NotImplementedException();
	public virtual IList<System.Double> TransformParameterDomain(System.Double domainStart,System.Double domainEnd) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Determinant
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsIdentity
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Translation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Scale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
