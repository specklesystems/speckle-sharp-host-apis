namespace Autodesk.Revit.DB;

public partial class DirectShape : Autodesk.Revit.DB.Element
{
	public virtual void SetTypeId(Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual void SetShape(Autodesk.Revit.DB.ShapeBuilder pBuilder) => throw new System.NotImplementedException();
	public virtual void AppendShape(Autodesk.Revit.DB.ShapeBuilder ShapeBuilder) => throw new System.NotImplementedException();
	public virtual void AddReferenceCurve(Autodesk.Revit.DB.Curve refCurve,Autodesk.Revit.DB.DirectShapeReferenceOptions options) => throw new System.NotImplementedException();
	public virtual void AddReferenceCurve(Autodesk.Revit.DB.Curve refCurve) => throw new System.NotImplementedException();
	public virtual void AddReferencePlane(Autodesk.Revit.DB.Plane refPlane,Autodesk.Revit.DB.BoundingBoxUV boundingBoxUV,Autodesk.Revit.DB.DirectShapeReferenceOptions options) => throw new System.NotImplementedException();
	public virtual void AddReferencePlane(Autodesk.Revit.DB.Plane refPlane,Autodesk.Revit.DB.DirectShapeReferenceOptions options) => throw new System.NotImplementedException();
	public virtual void AddReferencePlane(Autodesk.Revit.DB.Plane refPlane,Autodesk.Revit.DB.BoundingBoxUV boundingBoxUV) => throw new System.NotImplementedException();
	public virtual void AddReferencePlane(Autodesk.Revit.DB.Plane refPlane) => throw new System.NotImplementedException();
	public virtual void AddReferencePoint(Autodesk.Revit.DB.XYZ refPoint,Autodesk.Revit.DB.DirectShapeReferenceOptions options) => throw new System.NotImplementedException();
	public virtual void AddReferencePoint(Autodesk.Revit.DB.XYZ refPoint) => throw new System.NotImplementedException();
	public virtual void AddExternallyTaggedGeometry(Autodesk.Revit.DB.ExternallyTaggedGeometryObject externallyTaggedGeometry) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternallyTaggedGeometryObject GetExternallyTaggedGeometry(Autodesk.Revit.DB.ExternalGeometryId externalId) => throw new System.NotImplementedException();
	public virtual void UpdateExternallyTaggedGeometry(Autodesk.Revit.DB.ExternallyTaggedGeometryObject externallyTaggedGeometry) => throw new System.NotImplementedException();
	public virtual void RemoveExternallyTaggedGeometry(Autodesk.Revit.DB.ExternalGeometryId externalId) => throw new System.NotImplementedException();
	public virtual void ResetExternallyTaggedGeometry() => throw new System.NotImplementedException();
	public virtual void SetOptions(Autodesk.Revit.DB.DirectShapeOptions options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DirectShapeOptions GetOptions() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId TypeId
	{
		get => throw new System.NotImplementedException();
	}
}
