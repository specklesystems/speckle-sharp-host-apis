namespace Autodesk.Revit.DB.Structure;

public partial class RebarCurvesData : System.IDisposable
{
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetAddedBarGeometry(System.Int32 barIndex) => throw new System.NotImplementedException();
	public virtual void ClearAllAddedBarGeometry() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult AddBarGeometry(Autodesk.Revit.DB.CurveLoop curves) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult AddBarGeometry(System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves) => throw new System.NotImplementedException();
	public virtual System.Boolean CanAddBarGeometry() => throw new System.NotImplementedException();
	public virtual System.Int32 GetNumberOfBarGeometry() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetDistributionPath() => throw new System.NotImplementedException();
	public virtual void SetDistributionPath(System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> path) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarUpdateCurvesData GetRebarUpdateCurvesData() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
