namespace Autodesk.Revit.Creation;

public partial class Document : Autodesk.Revit.Creation.ItemFactoryBase
{
  public Document() { }

  public virtual Autodesk.Revit.DB.SpotDimension NewSpotCoordinate(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Reference reference,
    Autodesk.Revit.DB.XYZ origin,
    Autodesk.Revit.DB.XYZ bend,
    Autodesk.Revit.DB.XYZ end,
    Autodesk.Revit.DB.XYZ refPt,
    System.Boolean hasLeader
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SpotDimension NewSpotElevation(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Reference reference,
    Autodesk.Revit.DB.XYZ origin,
    Autodesk.Revit.DB.XYZ bend,
    Autodesk.Revit.DB.XYZ end,
    Autodesk.Revit.DB.XYZ refPt,
    System.Boolean hasLeader
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.Room NewRoom(
    Autodesk.Revit.DB.Architecture.Room room,
    Autodesk.Revit.DB.PlanCircuit circuit
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.Room NewRoom(Autodesk.Revit.DB.Phase phase) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.Room NewRoom(
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.UV point
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> NewRooms2(
    Autodesk.Revit.DB.Phase phase,
    System.Int32 count
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> NewRooms2(
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Phase phase
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> NewRooms2(
    Autodesk.Revit.DB.Level level
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.RoomTag NewRoomTag(
    Autodesk.Revit.DB.LinkElementId roomId,
    Autodesk.Revit.DB.UV point,
    Autodesk.Revit.DB.ElementId viewId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.BoundaryConditions NewPointBoundaryConditions(
    Autodesk.Revit.DB.Reference reference,
    Autodesk.Revit.DB.Structure.TranslationRotationValue X_Translation,
    System.Double X_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Y_Translation,
    System.Double Y_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Z_Translation,
    System.Double Z_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue X_Rotation,
    System.Double X_RotationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Y_Rotation,
    System.Double Y_RotationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Z_Rotation,
    System.Double Z_RotationSpringModulus
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.BoundaryConditions NewLineBoundaryConditions(
    Autodesk.Revit.DB.Element hostElement,
    Autodesk.Revit.DB.Structure.TranslationRotationValue X_Translation,
    System.Double X_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Y_Translation,
    System.Double Y_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Z_Translation,
    System.Double Z_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue X_Rotation,
    System.Double X_RotationSpringModulus
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.BoundaryConditions NewLineBoundaryConditions(
    Autodesk.Revit.DB.Reference reference,
    Autodesk.Revit.DB.Structure.TranslationRotationValue X_Translation,
    System.Double X_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Y_Translation,
    System.Double Y_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Z_Translation,
    System.Double Z_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue X_Rotation,
    System.Double X_RotationSpringModulus
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.BoundaryConditions NewAreaBoundaryConditions(
    Autodesk.Revit.DB.Element hostElement,
    Autodesk.Revit.DB.Structure.TranslationRotationValue X_Translation,
    System.Double X_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Y_Translation,
    System.Double Y_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Z_Translation,
    System.Double Z_TranslationSpringModulus
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.BoundaryConditions NewAreaBoundaryConditions(
    Autodesk.Revit.DB.Reference reference,
    Autodesk.Revit.DB.Structure.TranslationRotationValue X_Translation,
    System.Double X_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Y_Translation,
    System.Double Y_TranslationSpringModulus,
    Autodesk.Revit.DB.Structure.TranslationRotationValue Z_Translation,
    System.Double Z_TranslationSpringModulus
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Opening NewOpening(
    Autodesk.Revit.DB.Element hostElement,
    Autodesk.Revit.DB.CurveArray profile,
    System.Boolean bPerpendicularFace
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Opening NewOpening(
    Autodesk.Revit.DB.Wall wall,
    Autodesk.Revit.DB.XYZ pntStart,
    Autodesk.Revit.DB.XYZ pntEnd
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Opening NewOpening(
    Autodesk.Revit.DB.Level bottomLevel,
    Autodesk.Revit.DB.Level topLevel,
    Autodesk.Revit.DB.CurveArray profile
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Opening NewOpening(
    Autodesk.Revit.DB.Element famInstElement,
    Autodesk.Revit.DB.CurveArray profile,
    Autodesk.Revit.Creation.eRefFace iFace
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ModelCurve NewAreaBoundaryLine(
    Autodesk.Revit.DB.SketchPlane sketchPlane,
    Autodesk.Revit.DB.Curve geometryCurve,
    Autodesk.Revit.DB.ViewPlan areaView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.AreaTag NewAreaTag(
    Autodesk.Revit.DB.ViewPlan areaView,
    Autodesk.Revit.DB.Area room,
    Autodesk.Revit.DB.UV point
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Area NewArea(Autodesk.Revit.DB.ViewPlan areaView, Autodesk.Revit.DB.UV point) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementSet NewAreas(
    System.Collections.Generic.List<Autodesk.Revit.Creation.AreaCreationData> dataList
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FootPrintRoof NewFootPrintRoof(
    Autodesk.Revit.DB.CurveArray footPrint,
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.RoofType roofType,
    out Autodesk.Revit.DB.ModelCurveArray footPrintToModelCurvesMapping
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ExtrusionRoof NewExtrusionRoof(
    Autodesk.Revit.DB.CurveArray profile,
    Autodesk.Revit.DB.ReferencePlane refPlane,
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.RoofType roofType,
    System.Double extrusionStart,
    System.Double extrusionEnd
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.MechanicalSystem NewMechanicalSystem(
    Autodesk.Revit.DB.Connector baseEquipmentConnector,
    Autodesk.Revit.DB.ConnectorSet connectors,
    Autodesk.Revit.DB.Mechanical.DuctSystemType ductSystemType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Plumbing.PipingSystem NewPipingSystem(
    Autodesk.Revit.DB.Connector baseEquipmentConnector,
    Autodesk.Revit.DB.ConnectorSet connectors,
    Autodesk.Revit.DB.Plumbing.PipeSystemType pipingSystemType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.Space NewSpace(
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Phase phase,
    Autodesk.Revit.DB.UV point
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.Space NewSpace(
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.UV point
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.Space NewSpace(Autodesk.Revit.DB.Phase phase) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> NewSpaces2(
    Autodesk.Revit.DB.Phase phase,
    System.Int32 count
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> NewSpaces2(
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Phase phase,
    Autodesk.Revit.DB.View view
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.SpaceTag NewSpaceTag(
    Autodesk.Revit.DB.Mechanical.Space space,
    Autodesk.Revit.DB.UV point,
    Autodesk.Revit.DB.View view
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ModelCurveArray NewSpaceBoundaryLines(
    Autodesk.Revit.DB.SketchPlane sketchPlane,
    Autodesk.Revit.DB.CurveArray curves,
    Autodesk.Revit.DB.View view
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ModelCurveArray NewRoomBoundaryLines(
    Autodesk.Revit.DB.SketchPlane sketchPlane,
    Autodesk.Revit.DB.CurveArray curves,
    Autodesk.Revit.DB.View view
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.Zone NewZone(
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Phase phase
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> NewCurtainSystem2(
    Autodesk.Revit.DB.ReferenceArray faces,
    Autodesk.Revit.DB.CurtainSystemType curtainSystemType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurtainSystem NewCurtainSystem(
    Autodesk.Revit.DB.FaceArray faces,
    Autodesk.Revit.DB.CurtainSystemType curtainSystemType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SlabEdge NewSlabEdge(
    Autodesk.Revit.DB.SlabEdgeType SlabEdgeType,
    Autodesk.Revit.DB.Reference reference
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SlabEdge NewSlabEdge(
    Autodesk.Revit.DB.SlabEdgeType SlabEdgeType,
    Autodesk.Revit.DB.ReferenceArray references
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.Gutter NewGutter(
    Autodesk.Revit.DB.Architecture.GutterType GutterType,
    Autodesk.Revit.DB.Reference reference
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.Gutter NewGutter(
    Autodesk.Revit.DB.Architecture.GutterType GutterType,
    Autodesk.Revit.DB.ReferenceArray references
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.Fascia NewFascia(
    Autodesk.Revit.DB.Architecture.FasciaType FasciaType,
    Autodesk.Revit.DB.Reference reference
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.Fascia NewFascia(
    Autodesk.Revit.DB.Architecture.FasciaType FasciaType,
    Autodesk.Revit.DB.ReferenceArray references
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.Curve curve,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.Element host,
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.FlexDuct NewFlexDuct(
    Autodesk.Revit.DB.Connector connector1,
    Autodesk.Revit.DB.Connector connector2,
    Autodesk.Revit.DB.Mechanical.FlexDuctType ductType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.FlexDuct NewFlexDuct(
    Autodesk.Revit.DB.Connector connector,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points,
    Autodesk.Revit.DB.Mechanical.FlexDuctType ductType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.FlexDuct NewFlexDuct(
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points,
    Autodesk.Revit.DB.Mechanical.FlexDuctType ductType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Plumbing.FlexPipe NewFlexPipe(
    Autodesk.Revit.DB.Connector connector1,
    Autodesk.Revit.DB.Connector connector2,
    Autodesk.Revit.DB.Plumbing.FlexPipeType pipeType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Plumbing.FlexPipe NewFlexPipe(
    Autodesk.Revit.DB.Connector connector,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points,
    Autodesk.Revit.DB.Plumbing.FlexPipeType pipeType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Plumbing.FlexPipe NewFlexPipe(
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points,
    Autodesk.Revit.DB.Plumbing.FlexPipeType pipeType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewElbowFitting(
    Autodesk.Revit.DB.Connector connector1,
    Autodesk.Revit.DB.Connector connector2
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewTeeFitting(
    Autodesk.Revit.DB.Connector connector1,
    Autodesk.Revit.DB.Connector connector2,
    Autodesk.Revit.DB.Connector connector3
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewTransitionFitting(
    Autodesk.Revit.DB.Connector connector1,
    Autodesk.Revit.DB.Connector connector2
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewCrossFitting(
    Autodesk.Revit.DB.Connector connector1,
    Autodesk.Revit.DB.Connector connector2,
    Autodesk.Revit.DB.Connector connector3,
    Autodesk.Revit.DB.Connector connector4
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewUnionFitting(
    Autodesk.Revit.DB.Connector connector1,
    Autodesk.Revit.DB.Connector connector2
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewTakeoffFitting(
    Autodesk.Revit.DB.Connector connector,
    Autodesk.Revit.DB.MEPCurve curve
  ) => throw new System.NotImplementedException();
}
