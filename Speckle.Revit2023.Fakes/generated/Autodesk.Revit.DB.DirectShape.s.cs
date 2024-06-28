namespace Autodesk.Revit.DB;

public partial class DirectShape : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.DirectShape CreateElement(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public static IList<Autodesk.Revit.DB.GeometryObject> CreateGeometryInstance(Autodesk.Revit.DB.Document document,System.String definition_id,Autodesk.Revit.DB.Transform trf) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.DirectShape CreateElementInstance(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId typeId,Autodesk.Revit.DB.ElementId categoryId,System.String definitionId,Autodesk.Revit.DB.Transform trf) => throw new System.NotImplementedException();
	public virtual void SetTypeId(Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual void SetName(System.String name) => throw new System.NotImplementedException();
	public virtual void SetShape(Autodesk.Revit.DB.ShapeBuilder pBuilder) => throw new System.NotImplementedException();
	public virtual void SetShape(IList<Autodesk.Revit.DB.GeometryObject> pGeomArr,Autodesk.Revit.DB.DirectShapeTargetViewType viewType) => throw new System.NotImplementedException();
	public virtual void SetShape(IList<Autodesk.Revit.DB.GeometryObject> pGeomArr) => throw new System.NotImplementedException();
	public virtual void AppendShape(Autodesk.Revit.DB.ShapeBuilder ShapeBuilder) => throw new System.NotImplementedException();
	public virtual void AppendShape(IList<Autodesk.Revit.DB.GeometryObject> pGeomArr,Autodesk.Revit.DB.DirectShapeTargetViewType viewType) => throw new System.NotImplementedException();
	public virtual void AppendShape(IList<Autodesk.Revit.DB.GeometryObject> pGeomArr) => throw new System.NotImplementedException();
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
	public virtual void UpdateExternallyTaggedGeometry(Autodesk.Revit.DB.ExternallyTaggedGeometryObject externallyTaggedGeometry) => throw new System.NotImplementedException();
	public virtual void RemoveExternallyTaggedGeometry(Autodesk.Revit.DB.ExternalGeometryId externalId) => throw new System.NotImplementedException();
	public virtual void ResetExternallyTaggedGeometry() => throw new System.NotImplementedException();
	public virtual System.Boolean HasExternalGeometry(Autodesk.Revit.DB.ExternalGeometryId externalId) => throw new System.NotImplementedException();
	public virtual System.Boolean AreOptionsValid(Autodesk.Revit.DB.DirectShapeOptions options) => throw new System.NotImplementedException();
	public virtual System.Boolean AreOptionsValidForTransientDirectShape(Autodesk.Revit.DB.DirectShapeOptions options) => throw new System.NotImplementedException();
	public virtual void SetOptions(Autodesk.Revit.DB.DirectShapeOptions options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DirectShapeOptions GetOptions() => throw new System.NotImplementedException();
	public static System.Boolean IsValidCategoryId(Autodesk.Revit.DB.ElementId categoryId,Autodesk.Revit.DB.Document doc) => throw new System.NotImplementedException();
	public static System.Boolean IsSupportedDocument(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidTypeId(Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidGeometry(Autodesk.Revit.DB.Solid Geom) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidShape(IList<Autodesk.Revit.DB.GeometryObject> shape,Autodesk.Revit.DB.DirectShapeTargetViewType viewType) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidShape(IList<Autodesk.Revit.DB.GeometryObject> shape) => throw new System.NotImplementedException();
	public virtual System.Boolean CanCreateParts() => throw new System.NotImplementedException();
	public virtual System.String ApplicationDataId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String ApplicationId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId TypeId
	{
		get => throw new System.NotImplementedException();
	}
}
