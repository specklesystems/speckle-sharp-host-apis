namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalModelSketchComponent : System.IDisposable
{
	public AnalyticalModelSketchComponent() {}
	public virtual System.Boolean IsAutoDetectEnabled() => throw new System.NotImplementedException();
	public virtual void EnableAutoDetect() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod GetAnalyticalAlignmentMethod() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.AnalyticalProjectionType GetAnalyticalProjectionType() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetAnalyticalProjectionDatumPlane() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidAnalyticalAlignmentMethod(Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod alignmentMethod) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidAnalyticalProjectionType(Autodesk.Revit.DB.Structure.AnalyticalProjectionType projectionType) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidDatumPlaneForProjection(Autodesk.Revit.DB.ElementId datumPlaneId) => throw new System.NotImplementedException();
	public virtual void SetAnalyticalAlignmentMethod(Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod alignmentMethod) => throw new System.NotImplementedException();
	public virtual void SetAnalyticalProjectionType(Autodesk.Revit.DB.Structure.AnalyticalProjectionType projectionType) => throw new System.NotImplementedException();
	public virtual void SetAnalyticalProjectionDatumPlane(Autodesk.Revit.DB.ElementId datumPlaneId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetAutoDetectMatchedElements() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetComponentElementId() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
