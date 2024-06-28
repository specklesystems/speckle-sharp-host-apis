namespace Autodesk.Revit.DB;

public partial class Transform : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.DB.XYZ OfPoint(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ OfVector(Autodesk.Revit.DB.XYZ vec) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform Multiply(Autodesk.Revit.DB.Transform right) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform Inverse
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Origin
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ BasisZ
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ BasisY
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ BasisX
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
