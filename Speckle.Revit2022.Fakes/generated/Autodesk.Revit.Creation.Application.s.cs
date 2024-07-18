namespace Autodesk.Revit.Creation;

public partial class Application : Autodesk.Revit.DB.APIObject
{
  public Application() { }

  public virtual Autodesk.Revit.DB.CategorySet NewCategorySet() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.InstanceBinding NewInstanceBinding(Autodesk.Revit.DB.CategorySet categorySet) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.InstanceBinding NewInstanceBinding() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TypeBinding NewTypeBinding(Autodesk.Revit.DB.CategorySet categorySet) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TypeBinding NewTypeBinding() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementSet NewElementSet() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Options NewGeometryOptions() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveArray NewCurveArray() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveArrArray NewCurveArrArray() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.VertexIndexPair NewVertexIndexPair(System.Int32 iTop, System.Int32 iBottom) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.VertexIndexPairArray NewVertexIndexPairArray() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CombinableElementArray NewCombinableElementArray() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Color NewColor() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ProjectPosition NewProjectPosition(
    System.Double ew,
    System.Double ns,
    System.Double elevation,
    System.Double angle
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.BoundingBoxXYZ NewBoundingBoxXYZ() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.BoundingBoxUV NewBoundingBoxUV(
    System.Double min_u,
    System.Double min_v,
    System.Double max_u,
    System.Double max_v
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.BoundingBoxUV NewBoundingBoxUV() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ NewXYZ(Autodesk.Revit.DB.XYZ xyz) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ NewXYZ(System.Double x, System.Double y, System.Double z) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ NewXYZ() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.UV NewUV(Autodesk.Revit.DB.UV uv) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.UV NewUV(System.Double u, System.Double v) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.UV NewUV() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DWFExportOptions NewDWFExportOptions() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DWFXExportOptions NewDWFXExportOptions() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FBXExportOptions NewFBXExportOptions() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.GBXMLImportOptions NewGBXMLImportOptions() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DoubleArray NewDoubleArray() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ReferenceArray NewReferenceArray() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FaceArray NewFaceArray() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.IntersectionResultArray NewIntersectionResultArray() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ViewSet NewViewSet() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.SpaceSet NewSpaceSet() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.Creation.FamilyInstanceCreationData NewFamilyInstanceCreationData(
    Autodesk.Revit.DB.FamilySymbol symbol,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> adaptivePoints
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.Creation.FamilyInstanceCreationData NewFamilyInstanceCreationData(
    Autodesk.Revit.DB.Face face,
    Autodesk.Revit.DB.Line position,
    Autodesk.Revit.DB.FamilySymbol symbol
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.Creation.FamilyInstanceCreationData NewFamilyInstanceCreationData(
    Autodesk.Revit.DB.Face face,
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.XYZ referenceDirection,
    Autodesk.Revit.DB.FamilySymbol symbol
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.Creation.FamilyInstanceCreationData NewFamilyInstanceCreationData(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.XYZ referenceDirection,
    Autodesk.Revit.DB.Element host,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.Creation.FamilyInstanceCreationData NewFamilyInstanceCreationData(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.Element host,
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.Creation.FamilyInstanceCreationData NewFamilyInstanceCreationData(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.Element host,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.Creation.FamilyInstanceCreationData NewFamilyInstanceCreationData(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.Creation.FamilyInstanceCreationData NewFamilyInstanceCreationData(
    Autodesk.Revit.DB.Curve curve,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.Creation.FamilyInstanceCreationData NewFamilyInstanceCreationData(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.Creation.AreaCreationData NewAreaCreationData(
    Autodesk.Revit.DB.ViewPlan areaView,
    Autodesk.Revit.DB.UV point
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId NewElementId() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveLoopsProfile NewCurveLoopsProfile(Autodesk.Revit.DB.CurveArrArray curveLoops) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilySymbolProfile NewFamilySymbolProfile(
    Autodesk.Revit.DB.FamilySymbol familySymbol
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PointOnEdge NewPointOnEdge(
    Autodesk.Revit.DB.Reference edgeReference,
    Autodesk.Revit.DB.PointLocationOnCurve locationOnCurve
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PointOnPlane NewPointOnPlane(
    Autodesk.Revit.DB.Reference planeReference,
    Autodesk.Revit.DB.UV position,
    Autodesk.Revit.DB.UV xvec,
    System.Double offset
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PointOnFace NewPointOnFace(
    Autodesk.Revit.DB.Reference faceReference,
    Autodesk.Revit.DB.UV uv
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PointOnEdgeEdgeIntersection NewPointOnEdgeEdgeIntersection(
    Autodesk.Revit.DB.Reference edgeReference1,
    Autodesk.Revit.DB.Reference edgeReference2
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PointOnEdgeFaceIntersection NewPointOnEdgeFaceIntersection(
    Autodesk.Revit.DB.Reference edgeReference,
    Autodesk.Revit.DB.Reference faceReference,
    System.Boolean orientWithEdge
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PointRelativeToPoint NewPointRelativeToPoint(
    Autodesk.Revit.DB.Reference hostPointReference
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ReferencePointArray NewReferencePointArray() =>
    throw new System.NotImplementedException();
}
