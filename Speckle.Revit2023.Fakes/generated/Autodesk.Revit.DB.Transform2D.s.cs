namespace Autodesk.Revit.DB;

public partial class Transform2D : System.Object
{
	public virtual void Assign(Autodesk.Revit.DB.Transform2D from) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform2D SetToIdentity() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform2D Multiply(Autodesk.Revit.DB.Transform2D right) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV OfPoint(Autodesk.Revit.DB.UV point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV OfVector(Autodesk.Revit.DB.UV vector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform2D GetInverse() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxUV TransformUVDomainIfPossible(Autodesk.Revit.DB.BoundingBoxUV uvDomain) => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.UV BasisV
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.UV BasisU
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.UV Origin
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
