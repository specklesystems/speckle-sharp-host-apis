namespace Autodesk.Revit.DB;

public partial class Frame : System.IDisposable
{
	public Frame() {}
	public Frame(Autodesk.Revit.DB.XYZ origin,Autodesk.Revit.DB.XYZ vec1,Autodesk.Revit.DB.XYZ vec2,Autodesk.Revit.DB.XYZ vec3) => throw new System.NotImplementedException();
	public static System.Boolean CanDefineRevitGeometry(Autodesk.Revit.DB.Frame frameOfReference) => throw new System.NotImplementedException();
	public virtual void Transform(Autodesk.Revit.DB.Transform trf) => throw new System.NotImplementedException();
	public virtual System.Boolean IsOrthogonal() => throw new System.NotImplementedException();
	public virtual System.Boolean IsOrthonormal() => throw new System.NotImplementedException();
	public virtual System.Boolean IsRightHanded() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
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
	public virtual Autodesk.Revit.DB.XYZ Origin
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
