namespace Autodesk.Revit.DB;

public partial class FabricationPart : Autodesk.Revit.DB.Element
{
  public FabricationPart() { }

  public virtual System.Boolean RemovePartCustomData(System.Int32 customId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationAncillaryUsage> GetPartAncillaryUsage() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSameAs(
    Autodesk.Revit.DB.FabricationPart part,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Fabrication.FabricationPartCompareType> ignoreFields
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.GeometryElement GetInsulationLiningGeometry() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationVersionInfo> GetVersionHistory() =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.FabricationPart Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.FabricationItemFile itemFile,
    Autodesk.Revit.DB.ElementId levelId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.FabricationPart Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.FabricationServiceButton button,
    System.Int32 condition,
    Autodesk.Revit.DB.ElementId levelId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.FabricationPart Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.FabricationServiceButton button,
    System.Double width,
    System.Double depth,
    Autodesk.Revit.DB.ElementId levelId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.FabricationPart CreateHanger(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.FabricationServiceButton button,
    System.Int32 condition,
    Autodesk.Revit.DB.ElementId levelId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.FabricationPart CreateHanger(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.FabricationServiceButton button,
    System.Int32 condition,
    Autodesk.Revit.DB.ElementId hostId,
    Autodesk.Revit.DB.Connector hostConnector,
    System.Double distance,
    System.Boolean attachToStructure
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.FabricationPart CreateHanger(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.FabricationServiceButton button,
    Autodesk.Revit.DB.ElementId hostId,
    Autodesk.Revit.DB.Connector hostConnector,
    System.Double distance,
    System.Boolean attachToStructure
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FabricationHostedInfo GetHostedInfo() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FabricationRodInfo GetRodInfo() => throw new System.NotImplementedException();

  public virtual System.Boolean IsProductListEntryCompatibleSize(System.Int32 productEntry) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Fabrication.FabricationPartFitResult StretchAndFit(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Connector stretchConnector,
    Autodesk.Revit.DB.Fabrication.FabricationPartRouteEnd target,
    out System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> newPartIds
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> SaveAsFabricationJob(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> ids,
    System.String filename,
    Autodesk.Revit.DB.Fabrication.FabricationSaveJobOptions saveOptions
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanASlopeBeApplied() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetTransform() => throw new System.NotImplementedException();

  public virtual void SetPositionByEnd(Autodesk.Revit.DB.Connector connector, Autodesk.Revit.DB.XYZ position) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationDimensionDefinition> GetDimensions() =>
    throw new System.NotImplementedException();

  public virtual System.Double GetDimensionValue(Autodesk.Revit.DB.FabricationDimensionDefinition dim) =>
    throw new System.NotImplementedException();

  public virtual void SetDimensionValue(Autodesk.Revit.DB.FabricationDimensionDefinition dim, System.Double newValue) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsDimensionCalculated(Autodesk.Revit.DB.FabricationDimensionDefinition dim) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.String> GetDimensionCalculatedOptions(
    Autodesk.Revit.DB.FabricationDimensionDefinition dim
  ) => throw new System.NotImplementedException();

  public virtual System.String GetCalculatedDimensionValue(Autodesk.Revit.DB.FabricationDimensionDefinition dim) =>
    throw new System.NotImplementedException();

  public virtual void SetCalculatedDimensionValue(
    Autodesk.Revit.DB.FabricationDimensionDefinition dim,
    System.String value
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanAdjustEndLength(Autodesk.Revit.DB.Connector partConn) =>
    throw new System.NotImplementedException();

  public virtual System.Double AdjustEndLength(
    Autodesk.Revit.DB.Connector partConn,
    System.Double lengthToAdjust,
    System.Boolean totalLengthOnly
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsAStraight() => throw new System.NotImplementedException();

  public virtual System.Boolean IsAHanger() => throw new System.NotImplementedException();

  public virtual System.Boolean IsATap() => throw new System.NotImplementedException();

  public virtual System.Boolean IsProductList() => throw new System.NotImplementedException();

  public virtual System.String GetProductListEntryName(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetProductListEntryCount() => throw new System.NotImplementedException();

  public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> OptimizeLengths(
    Autodesk.Revit.DB.Document doc,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> partIds
  ) => throw new System.NotImplementedException();

  public static void Reposition(Autodesk.Revit.DB.Document doc, Autodesk.Revit.DB.ElementId partId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanSplitStraight(Autodesk.Revit.DB.XYZ position) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId SplitStraight(Autodesk.Revit.DB.XYZ position) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId SplitStraight(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId partId,
    Autodesk.Revit.DB.XYZ position
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanFlipPart() => throw new System.NotImplementedException();

  public virtual System.Boolean Flip() => throw new System.NotImplementedException();

  public static System.Boolean ConnectAndCouple(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.Connector partConn,
    Autodesk.Revit.DB.Connector toConn
  ) => throw new System.NotImplementedException();

  public static System.Boolean AlignPartByConnectors(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.Connector partConn,
    Autodesk.Revit.DB.Connector toConn,
    System.Double axisRotation
  ) => throw new System.NotImplementedException();

  public static System.Boolean AlignPartByConnectorToConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Connector connector,
    Autodesk.Revit.DB.Connector fixedConnector,
    System.Double rotation,
    System.Double slope,
    Autodesk.Revit.DB.Fabrication.FabricationPartJustification justification
  ) => throw new System.NotImplementedException();

  public static System.Boolean AlignPartByInsertionPoint(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId partId,
    Autodesk.Revit.DB.XYZ position,
    System.Double rotation,
    System.Double rotationPerpendicular,
    System.Double slope,
    Autodesk.Revit.DB.Fabrication.FabricationPartJustification justification,
    Autodesk.Revit.DB.Transform trf
  ) => throw new System.NotImplementedException();

  public static System.Boolean AlignPartByConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Connector connector,
    Autodesk.Revit.DB.XYZ position,
    System.Double rotation,
    System.Double rotationPerpendicular,
    System.Double slope,
    Autodesk.Revit.DB.Fabrication.FabricationPartJustification justification,
    Autodesk.Revit.DB.Transform trf
  ) => throw new System.NotImplementedException();

  public static System.Boolean AlignPartByInsertionPointAndCutInToStraight(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId straightId,
    Autodesk.Revit.DB.ElementId partId,
    Autodesk.Revit.DB.XYZ position,
    System.Double rotation,
    System.Double slope,
    System.Boolean flip
  ) => throw new System.NotImplementedException();

  public static void RotateConnectedTap(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.FabricationPart tap,
    System.Double primaryAxisRotateBy,
    System.Double secondaryAxisRotateBy
  ) => throw new System.NotImplementedException();

  public static void PlaceAsTap(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.Connector tapPartConn,
    Autodesk.Revit.DB.Connector hostPartConn,
    System.Double distance,
    System.Double axisRotation,
    System.Double secondaryAxisRotation
  ) => throw new System.NotImplementedException();

  public static System.Boolean PlaceFittingAsCutIn(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId straightId,
    Autodesk.Revit.DB.ElementId fittingId,
    Autodesk.Revit.DB.XYZ position,
    Autodesk.Revit.DB.Connector fittingConn,
    System.Double axisRotation
  ) => throw new System.NotImplementedException();

  public static void RotateConnectedPartByConnector(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.Connector conn,
    System.Double axisRotationBy
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean HasNoConnections() => throw new System.NotImplementedException();

  public virtual System.Boolean HasCustomData(System.Int32 customId) => throw new System.NotImplementedException();

  public virtual System.String GetPartCustomDataText(System.Int32 customId) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetPartCustomDataInteger(System.Int32 customId) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetPartCustomDataReal(System.Int32 customId) =>
    throw new System.NotImplementedException();

  public virtual void SetPartCustomDataText(System.Int32 customId, System.String value) =>
    throw new System.NotImplementedException();

  public virtual void SetPartCustomDataInteger(System.Int32 customId, System.Int32 value) =>
    throw new System.NotImplementedException();

  public virtual void SetPartCustomDataReal(System.Int32 customId, System.Double value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean AddPartCustomData(System.Int32 customId) => throw new System.NotImplementedException();

  public virtual System.Int32 ServiceType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String SpoolName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid PartGuid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 PartStatus
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 HangerRodKit
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Fabrication.ValidationStatus ValidationStatus
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ConnectorManager ConnectorManager
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ConnectorDomainType DomainType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ItemCustomId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ItemNumber
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 Material
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 InsulationSpecification
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 Specification
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ServiceId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ProductCode
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double CenterlineLength
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ Origin
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double LevelOffset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ProductInstallType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ProductOriginalEquipmentManufacture
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ProductDataRange
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ProductSizeDescription
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ProductMaterialDescription
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ProductSpecificationDescription
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ProductFinishDescription
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ProductLongDescription
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ProductShortDescription
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ProductName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String VendorCode
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Vendor
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Alias
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Notes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsBoughtOut
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ServiceName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 CutType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double DoubleWallMaterialArea
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double DoubleWallMaterialThickness
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 DoubleWallMaterial
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double MaterialThickness
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double SheetMetalArea
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double LiningArea
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double LiningThickness
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String LiningType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double InsulationArea
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double InsulationThickness
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String InsulationType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Weight
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String FreeSize
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String OverallSize
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Size
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Slope
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasLining
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasInsulation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasDoubleWall
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ServiceAbbreviation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double BottomOfPartElevation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double TopOfPartElevation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ProductListEntry
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
