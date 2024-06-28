namespace Autodesk.Revit.DB;

public partial class DirectShapeType : Autodesk.Revit.DB.ElementType
{
	public virtual Autodesk.Revit.DB.DirectShapeTypeUserAssignability get_UserAssignability() => throw new System.NotImplementedException();
	public virtual void set_UserAssignability(Autodesk.Revit.DB.DirectShapeTypeUserAssignability userAssignability) => throw new System.NotImplementedException();
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
	public virtual void RemoveExternallyTaggedGeometry(Autodesk.Revit.DB.ExternalGeometryId externalId) => throw new System.NotImplementedException();
	public virtual void UpdateExternallyTaggedGeometry(Autodesk.Revit.DB.ExternallyTaggedGeometryObject externallyTaggedGeometry) => throw new System.NotImplementedException();
	public virtual void ResetExternallyTaggedGeometry() => throw new System.NotImplementedException();
	public virtual void SetOptions(Autodesk.Revit.DB.DirectShapeTypeOptions options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DirectShapeTypeOptions GetOptions() => throw new System.NotImplementedException();
}
