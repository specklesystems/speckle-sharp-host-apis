namespace Autodesk.Revit.DB;

public partial class NurbsSurfaceData : System.Object
{
	public NurbsSurfaceData(Autodesk.Revit.DB.NurbsSurfaceData other) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.NurbsSurfaceData Create(System.Int32 degreeU,System.Int32 degreeV,IList<System.Double> knotsU,IList<System.Double> knotsV,IList<Autodesk.Revit.DB.XYZ> controlPoints,IList<System.Double> weights,System.Boolean bReverseOrientation) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValid() => throw new System.NotImplementedException();
	public virtual IList<System.Double> GetKnotsU() => throw new System.NotImplementedException();
	public virtual IList<System.Double> GetKnotsV() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.XYZ> GetControlPoints() => throw new System.NotImplementedException();
	public virtual IList<System.Double> GetWeights() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ReverseOrientation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsRational
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 DegreeV
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 DegreeU
	{
		get => throw new System.NotImplementedException();
	}
}
