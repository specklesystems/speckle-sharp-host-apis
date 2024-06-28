namespace Autodesk.Revit.DB;

public partial class XYZ : System.Object
{
	public virtual System.Boolean IsZeroLength() => throw new System.NotImplementedException();
	public virtual System.Boolean IsUnitLength() => throw new System.NotImplementedException();
	public static System.Boolean IsWithinLengthLimits(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Normalize() => throw new System.NotImplementedException();
	public virtual System.Double GetLength() => throw new System.NotImplementedException();
	public virtual System.Double DotProduct(Autodesk.Revit.DB.XYZ source) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ CrossProduct(Autodesk.Revit.DB.XYZ source) => throw new System.NotImplementedException();
	public virtual System.Double TripleProduct(Autodesk.Revit.DB.XYZ middle,Autodesk.Revit.DB.XYZ right) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Add(Autodesk.Revit.DB.XYZ source) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Subtract(Autodesk.Revit.DB.XYZ source) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Negate() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Multiply(System.Double value) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Divide(System.Double value) => throw new System.NotImplementedException();
	public virtual System.Boolean IsAlmostEqualTo(Autodesk.Revit.DB.XYZ source,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsAlmostEqualTo(Autodesk.Revit.DB.XYZ source) => throw new System.NotImplementedException();
	public virtual System.Double DistanceTo(Autodesk.Revit.DB.XYZ source) => throw new System.NotImplementedException();
	public virtual System.Double AngleTo(Autodesk.Revit.DB.XYZ source) => throw new System.NotImplementedException();
	public virtual System.Double AngleOnPlaneTo(Autodesk.Revit.DB.XYZ right,Autodesk.Revit.DB.XYZ normal) => throw new System.NotImplementedException();
	public virtual System.Double Z
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Y
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double X
	{
		get => throw new System.NotImplementedException();
	}
}
