namespace Autodesk.Revit.DB;

public partial class Outline : System.IDisposable
{
	public Outline() {}
	public Outline(Autodesk.Revit.DB.XYZ minimumPoint,Autodesk.Revit.DB.XYZ maximumPoint) => throw new System.NotImplementedException();
	public Outline(Autodesk.Revit.DB.Outline other) => throw new System.NotImplementedException();
	public virtual void Scale(System.Double scale) => throw new System.NotImplementedException();
	public virtual System.Boolean IsScaleValid(System.Double scale) => throw new System.NotImplementedException();
	public virtual void AddPoint(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual System.Boolean Intersects(Autodesk.Revit.DB.Outline outline,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(Autodesk.Revit.DB.XYZ point,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean ContainsOtherOutline(Autodesk.Revit.DB.Outline otherOutline,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Double GetDiagonalLength() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsEmpty
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ MaximumPoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ MinimumPoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
