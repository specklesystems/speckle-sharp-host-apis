namespace Autodesk.Revit.DB;

public partial class DirectShapeType : Autodesk.Revit.DB.ElementType
{
	public DirectShapeType() {}
	public static Autodesk.Revit.DB.DirectShapeType Create(Autodesk.Revit.DB.Document document,System.String name,Autodesk.Revit.DB.ElementId categoryId,Autodesk.Revit.DB.DirectShapeTypeOptions options) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.DirectShapeType Create(Autodesk.Revit.DB.Document document,System.String name,Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual void SetFamilyName(System.String name) => throw new System.NotImplementedException();
	public virtual System.Boolean CanChangeFamilyName() => throw new System.NotImplementedException();
	public virtual void SetShape(Autodesk.Revit.DB.ShapeBuilder pBuilder) => throw new System.NotImplementedException();
	public virtual void SetShape(System.Collections.Generic.IList<Autodesk.Revit.DB.GeometryObject> pGeomArr) => throw new System.NotImplementedException();
	public virtual void AppendShape(Autodesk.Revit.DB.ShapeBuilder ShapeBuilder) => throw new System.NotImplementedException();
	public virtual void AppendShape(System.Collections.Generic.IList<Autodesk.Revit.DB.GeometryObject> pGeomArr,Autodesk.Revit.DB.DirectShapeTargetViewType viewType) => throw new System.NotImplementedException();
	public virtual void AppendShape(System.Collections.Generic.IList<Autodesk.Revit.DB.GeometryObject> pGeomArr) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidShape(System.Collections.Generic.IList<Autodesk.Revit.DB.GeometryObject> shape,Autodesk.Revit.DB.DirectShapeTargetViewType viewType) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidShape(System.Collections.Generic.IList<Autodesk.Revit.DB.GeometryObject> shape) => throw new System.NotImplementedException();
	public virtual System.Boolean CanCreateParts() => throw new System.NotImplementedException();
	public virtual void AddReferenceCurve(Autodesk.Revit.DB.Curve refCurve,Autodesk.Revit.DB.DirectShapeReferenceOptions options) => throw new System.NotImplementedException();
	public virtual void AddReferenceCurve(Autodesk.Revit.DB.Curve refCurve) => throw new System.NotImplementedException();
	public virtual void AddReferencePlane(Autodesk.Revit.DB.Plane refPlane,Autodesk.Revit.DB.BoundingBoxUV boundingBoxUV,Autodesk.Revit.DB.DirectShapeReferenceOptions options) => throw new System.NotImplementedException();
	public virtual void AddReferencePlane(Autodesk.Revit.DB.Plane refPlane,Autodesk.Revit.DB.DirectShapeReferenceOptions options) => throw new System.NotImplementedException();
	public virtual void AddReferencePlane(Autodesk.Revit.DB.Plane refPlane,Autodesk.Revit.DB.BoundingBoxUV boundingBoxUV) => throw new System.NotImplementedException();
	public virtual void AddReferencePlane(Autodesk.Revit.DB.Plane refPlane) => throw new System.NotImplementedException();
	public virtual void AddReferencePoint(Autodesk.Revit.DB.XYZ refPoint,Autodesk.Revit.DB.DirectShapeReferenceOptions options) => throw new System.NotImplementedException();
	public virtual void AddReferencePoint(Autodesk.Revit.DB.XYZ refPoint) => throw new System.NotImplementedException();
	public static System.Boolean IsValidReferenceCurve(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public static System.Boolean IsValidReferencePlaneBoundingBoxUV(Autodesk.Revit.DB.BoundingBoxUV boundingBoxUV) => throw new System.NotImplementedException();
	public virtual void AddExternallyTaggedGeometry(Autodesk.Revit.DB.ExternallyTaggedGeometryObject externallyTaggedGeometry) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternallyTaggedGeometryObject GetExternallyTaggedGeometry(Autodesk.Revit.DB.ExternalGeometryId externalId) => throw new System.NotImplementedException();
	public virtual void RemoveExternallyTaggedGeometry(Autodesk.Revit.DB.ExternalGeometryId externalId) => throw new System.NotImplementedException();
	public virtual void UpdateExternallyTaggedGeometry(Autodesk.Revit.DB.ExternallyTaggedGeometryObject externallyTaggedGeometry) => throw new System.NotImplementedException();
	public virtual void ResetExternallyTaggedGeometry() => throw new System.NotImplementedException();
	public virtual System.Boolean HasExternalGeometry(Autodesk.Revit.DB.ExternalGeometryId externalId) => throw new System.NotImplementedException();
	public virtual System.Boolean AreOptionsValid(Autodesk.Revit.DB.DirectShapeTypeOptions options) => throw new System.NotImplementedException();
	public virtual void SetOptions(Autodesk.Revit.DB.DirectShapeTypeOptions options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DirectShapeTypeOptions GetOptions() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DirectShapeTypeUserAssignability UserAssignability
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
