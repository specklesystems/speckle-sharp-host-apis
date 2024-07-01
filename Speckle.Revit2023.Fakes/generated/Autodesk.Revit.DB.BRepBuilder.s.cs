namespace Autodesk.Revit.DB;

public partial class BRepBuilder : Autodesk.Revit.DB.ShapeBuilder
{
  public BRepBuilder(Autodesk.Revit.DB.BRepType geomType) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.BRepBuilderGeometryId AddFace(
    Autodesk.Revit.DB.BRepBuilderSurfaceGeometry surfaceGeom,
    System.Boolean bFaceIsReversed
  ) => throw new System.NotImplementedException();

  public virtual void FinishFace(Autodesk.Revit.DB.BRepBuilderGeometryId faceId) =>
    throw new System.NotImplementedException();

  public virtual void SetFaceMaterialId(
    Autodesk.Revit.DB.BRepBuilderGeometryId faceId,
    Autodesk.Revit.DB.ElementId materialId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.BRepBuilderGeometryId AddLoop(Autodesk.Revit.DB.BRepBuilderGeometryId faceId) =>
    throw new System.NotImplementedException();

  public virtual void FinishLoop(Autodesk.Revit.DB.BRepBuilderGeometryId loopId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.BRepBuilderGeometryId AddEdge(Autodesk.Revit.DB.BRepBuilderEdgeGeometry edgeGeom) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.BRepBuilderGeometryId AddCoEdge(
    Autodesk.Revit.DB.BRepBuilderGeometryId loopId,
    Autodesk.Revit.DB.BRepBuilderGeometryId edgeId,
    System.Boolean bCoEdgeIsReversed
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.BRepBuilderOutcome Finish() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ExternallyTaggedBRep GetResult(
    Autodesk.Revit.DB.ExternalGeometryId externalId,
    Autodesk.Revit.DB.BRepBuilderPersistentIds brepPersistentIds
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Solid GetResult() => throw new System.NotImplementedException();

  public virtual System.Boolean CanAddGeometry() => throw new System.NotImplementedException();

  public virtual System.Boolean IsResultAvailable() => throw new System.NotImplementedException();

  public static System.Boolean IsPermittedSurfaceType(Autodesk.Revit.DB.Surface surface) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidFaceId(Autodesk.Revit.DB.BRepBuilderGeometryId faceId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidLoopId(Autodesk.Revit.DB.BRepBuilderGeometryId loopId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidEdgeId(Autodesk.Revit.DB.BRepBuilderGeometryId edgeId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidPersistentIdsMap(Autodesk.Revit.DB.BRepBuilderPersistentIds brepPersistentIds) =>
    throw new System.NotImplementedException();

  public virtual void AllowRemovalOfProblematicFaces() => throw new System.NotImplementedException();

  public virtual System.Boolean RemovedSomeFaces() => throw new System.NotImplementedException();

  public virtual void SetAllowShortEdges() => throw new System.NotImplementedException();
}
