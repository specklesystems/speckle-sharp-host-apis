namespace Autodesk.Revit.DB;

public partial class Transform2D : System.Object
{
	public Transform2D(Autodesk.Revit.DB.UV uVec,Autodesk.Revit.DB.UV vVec,Autodesk.Revit.DB.UV origin) => throw new System.NotImplementedException();
	public Transform2D(Autodesk.Revit.DB.Transform2D other) => throw new System.NotImplementedException();
	public virtual System.Boolean AlmostEqual(Autodesk.Revit.DB.Transform2D right) => throw new System.NotImplementedException();
	public virtual void Assign(Autodesk.Revit.DB.Transform2D from) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform2D SetToIdentity() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Transform2D CreateIdentity() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform2D Multiply(Autodesk.Revit.DB.Transform2D right) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV OfPoint(Autodesk.Revit.DB.UV point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV OfVector(Autodesk.Revit.DB.UV vector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform2D PreScale(System.Double scale) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform2D PostScale(System.Double scale) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform2D GetInverse() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxUV TransformUVDomainIfPossible(Autodesk.Revit.DB.BoundingBoxUV uvDomain) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Scale
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasReflection
	{
		get => throw new System.NotImplementedException();
	}
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
	public virtual System.Double Determinant
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsConformal
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsTranslation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsIdentity
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.UV Origin
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
