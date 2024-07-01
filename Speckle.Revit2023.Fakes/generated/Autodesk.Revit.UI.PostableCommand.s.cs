namespace Autodesk.Revit.UI;

public enum PostableCommand
{
  RoofByFace,
  Soffit,
  LoadAsGroupIntoOpenProjects,
  LoadIntoProject,
  RepeatComponent,
  ConnectionSettings,
  StructuralConnection,
  ShowWarningsInViews,
  ViewList,
  LinearDimensionTypes,
  AngularDimensionTypes,
  SplitElement,
  SpotElevation,
  SpotCoordinate,
  AlignmentStation,
  AlignmentStationSet,
  RoofByFootprint,
  RoofByExtrusion,
  RadialDimensionTypes,
  ReloadLatest,
  Render,
  ShowHistory,
  SplitSurface,
  DrawOnFace,
  DrawOnWorkPlane,
  GrayInactiveWorksets,
  ImportGBXML,
  ExportReportsRoomOrAreaReport,
  SheetIssuesOrRevisions,
  RevisionSchedule,
  CalloutTags,
  ElevationTags,
  SectionTags,
  FloorByFaceFloor,
  HideCategory,
  RunInterferenceCheck,
  SpecifyCoordinatesAtPoint,
  ExportIFC,
  SystemBrowser,
  ResetAnalyticalModel,
  ExportOptionsIFCOptions,
  ExportDWFOrDWFx,
  ExportCADFormatsDWG,
  ExportCADFormatsDXF,
  ExportCADFormatsDGN,
  ExportCADFormatsACIS_SAT,
  ExportPDF,
  ExportCADFormatsSTL,
  ExportCADFormatsOBJ,
  OpenIFC,
  RelinquishAllMine,
  MaterialTakeoff,
  DWFMarkup,
  ImportTypes,
  ExportExportTypes,
  OpenIFCOptions,
  CheckMemberSupports,
  AnalyticalConsistencyChecks,
  KeynoteLegend,
  KeynotingSettings,
  OpenBuildingComponent,
  Web,
  TopChord,
  BottomChord,
  ShapeStatus,
  TogglePropertiesPalette,
  CoordinationModel,
  StatusBarWorksets,
  StatusBarDesignOptions,
  ReinforcementNumbers,
  FamilyCategoryAndParameters,
  ExportImagesandAnimationsWalkthrough,
  ExportImagesandAnimationsSolarStudy,
  SunSettings,
  Grid,
  ArchitecturalWall,
  Door,
  Window,
  Delete,
  Space,
  SpaceTag,
  SpaceSeparator,
  TypeProperties,
  Level,
  FramingElevation,
  ArchitecturalFloor,
  Stair,
  ArchitecturalColumn,
  MirrorProject,
  RotateProjectNorth,
  Rotate,
  MirrorPickAxis,
  LineWeights,
  ObjectStyles,
  AnalysisDisplayStyles,
  Snaps,
  ProjectUnits,
  StructuralPlan,
  FloorPlan,
  Section,
  Camera,
  ProjectBrowser,
  NewSheet,
  ImportCAD,
  LinkCAD,
  PointCloud,
  NewFamily,
  LoadShapes,
  NewConceptualMass,
  LoadAutodeskFamily,
  Pin,
  Walkthrough,
  Unpin,
  SolidExtrusion,
  PlaceAComponent,
  ModelLine,
  StairPath,
  ReferencePlane,
  Redo,
  Undo,
  Control,
  PickAPlane,
  Filters,
  TemporaryDimensions,
  LinePatterns,
  Array,
  Move,
  Copy,
  PlaceView,
  Text,
  NewTitleBlock,
  AutomaticCeiling,
  FillPatterns,
  Default3DView,
  Label,
  VisibilityOrGraphics,
  Opening,
  NewProject,
  ActivateView,
  Materials,
  DeactivateView,
  MaterialAssets,
  DecalTypes,
  Options,
  Room,
  CurtainGrid,
  CurtainWallMullion,
  FamilyTypes,
  FilledRegion,
  RoomTag,
  Align,
  Symbol,
  DuplicateView,
  ExportOptionsExportSetupsDGN,
  ExportOptionsExportSetupsDWGOrDXF,
  ColorFillLegend,
  BuildingElevation,
  JoinOrUnjoinRoof,
  SolidBlend,
  ManageLinks,
  SolidRevolve,
  ScheduleOrQuantities,
  Callout,
  SolidSweep,
  CreateGroup,
  Ramp,
  RoomSeparator,
  AlignedToCurrentView,
  AlignedToPickedLevel,
  WallJoins,
  StartingView,
  AlignedToSelectedLevels,
  TagByCategory,
  AlignedToSelectedViews,
  LoadedTagsAndSymbols,
  NewAnnotationSymbol,
  AlignedToSamePlace,
  SpotSlopeTypes,
  Arrowheads,
  SpotElevationTypes,
  SpotCoordinateTypes,
  ReviewWarnings,
  AlignmentStationLabelTypes,
  LineStyles,
  ReflectedCeilingPlan,
  DetailLevel,
  VoidExtrusion,
  VoidBlend,
  VoidRevolve,
  VoidSweep,
  CutGeometry,
  UncutGeometry,
  PlaceDetailGroup,
  OverrideByCategory,
  DetailComponent,
  DetailLine,
  Insulation,
  CreateSimilar,
  Worksets,
  Phases,
  PropertyLine,
  BuildingPad,
  ImportImage,
  ImportPDF,
  MatchTypeProperties,
  ScopeBox,
  Linework,
  SetWorkPlane,
  DraftingView,
  Legend,
  Demolish,
  RevisionCloud,
  SynchronizeAndModifySettings,
  ProjectInformation,
  ModelInPlace,
  SheetList,
  AreaPlan,
  GradedRegion,
  Toposurface,
  ManageImages,
  ApplyTemplatePropertiesToCurrentView,
  RevealWall,
  SweepWall,
  Paint,
  RemovePaint,
  NoteBlock,
  ModelText,
  ShowHiddenLinesByElement,
  RemoveHiddenLinesByElement,
  ManageViewTemplates,
  CreateTemplateFromCurrentView,
  SplitFace,
  RestoreBackup,
  ExportODBCDatabase,
  LoadAsGroup,
  SaveAsLibraryGroup,
  ParkingComponent,
  TransferProjectStandards,
  SymbolicLine,
  CutProfile,
  ExportReportsSchedule,
  CloseInactiveViews,
  AreaTag,
  AreaBoundary,
  Area,
  JoinGeometry,
  UnjoinGeometry,
  SwitchJoinOrder,
  TagAllNotTagged,
  MergeSurfaces,
  SharedParameters,
  LegendComponent,
  Offset,
  PurgeUnused,
  PlaceDecal,
  TitleBlock,
  RebarLine,
  LabelContours,
  SplitWithGap,
  ThinLines,
  LinkRevit,
  ExportImagesandAnimationsImage,
  ProjectParameters,
  RelocateProject,
  RotateTrueNorth,
  DuplicateWithDetailing,
  Location,
  AcquireCoordinates,
  ReportSharedCoordinates,
  IdsOfSelection,
  SelectById,
  PublishCoordinates,
  ParametersService,
  PlanRegion,
  BrowserOrganization,
  Matchline,
  ViewReference,
  DesignOptions,
  AddToSet,
  PickToEdit,
  EditingRequests,
  SaveAsLibraryFamily,
  Subregion,
  Railing,
  Beam,
  Brace,
  StructuralColumn,
  StructuralWall,
  SpanDirectionSymbol,
  StructuralFloor,
  Scale,
  Loads,
  StructuralSettings,
  ReferenceLine,
  RebarCoverSettings,
  ShowMassFormAndFloors,
  CurtainSystemByFace,
  WallByFaceWall,
  ShowMassByViewSettings,
  ShowMassSurfaceTypes,
  ShowMassZonesAndShades,
  StructuralRebar,
  CopyMonitorUseCurrentProject,
  CopyMonitorSelectLink,
  CoordinationReviewUseCurrentProject,
  CoordinationSelectLink,
  Wall,
  Isolated,
  MaterialTag,
  CoordinationSettings,
  Slab,
  ElementKeynote,
  MaterialKeynote,
  UserKeynote,
  LoadSelection,
  SaveSelection,
  EditSelection,
  ActivateControlsAndDimensions,
  ShowWorksharingMakeEditableControls,
  MultiCategoryTag,
  BoundaryConditions,
  StructuralPathReinforcement,
  PathReinforcementSymbol,
  OpeningByFace,
  VerticalOpening,
  DormerOpening,
  WallOpening,
  ShaftOpening,
  SpotSlope,
  HideElements,
  ToggleRevealHiddenElementsMode,
  OverrideByElement,
  OverrideByFilter,
  DuplicateAsDependent,
  MaskingRegion,
  MajorSegment,
  ReinforcementSettings,
  ExportFBX,
  OpenFamily,
  CreateParts,
  ViewCube,
  BeamAnnotations,
  AllowableBarTypes,
  MacroManager,
  MacroSecurity,
  NavigationBar,
  FormWorkPlaneView,
  ReconcileHosting,
  AdjustAnalyticalModel,
  DiameterDimension,
  DiameterDimensionTypes,
  StructuralFabricArea,
  FabricReinforcementSymbol,
  PlaceOnStairOrRamp,
  DuctPressureLossReport,
  PipePressureLossReport,
  OpenSampleFiles,
  SingleFabricSheetPlacement,
  AlignedMultiRebarAnnotation,
  LinearMultiRebarAnnotation,
  FabricationSettings,
  LinkIFC,
  SelectionBox,
  StructuralRebarCoupler,
  PAndIDModeler,
  PAndIDSettings,
  TogglePAndIDModelerBrowser,
  DuctAccessory,
  AirTerminal,
  Duct,
  MechanicalEquipment,
  DuctFitting,
  FlexDuct,
  ConvertToFlexDuct,
  DuctLegend,
  PanelSchedules,
  ElectricalSettings,
  LoadClassifications,
  LightingFixture,
  ElectricalEquipment,
  ElectricalFixture,
  CheckCircuits,
  DemandFactors,
  Pipe,
  FlexPipe,
  PipeFitting,
  PipeAccessory,
  ArcWire,
  PipeLegend,
  CheckPipeSystems,
  CheckDuctSystems,
  MechanicalSettings,
  PlumbingFixture,
  Sprinkler,
  ElectricalConnector,
  DuctConnector,
  PipeConnector,
  Zone,
  BuildingOrSpaceTypeSettings,
  ChamferedWire,
  SplineWire,
  Communication,
  Data,
  FireAlarm,
  Lighting,
  NurseCall,
  Security,
  Telephone,
  CableTrayConnector,
  ConduitConnector,
  CableTrayFitting,
  ConduitFitting,
  CableTray,
  Conduit,
  ManageTemplates,
  EditATemplate,
  ParallelConduits,
  DuctPlaceholder,
  PipePlaceholder,
  ParallelPipes,
  ShowDisconnects,
  MultiPointRouting,
  SystemZone,
  SiteComponent,
  AreaAndVolumeComputations,
  ShowWorkPlane,
  Fascia,
  Gutter,
  SlabEdgeFloor,
  CheckSpelling,
  RepeatingDetailComponent,
  InsertViewsFromFile,
  Insert2DElementsFromFile,
  SaveAsLibraryView,
  AutomaticBeamSystem,
  PlaceMass,
  InPlaceMass,
  SynchronizeNow,
  StructuralTrusses,
  CreateAnAreaBasedLoad,
  AreaBasedLoadBoundary,
  EquipmentLoad,
  ShowBoundaryOpenEnds,
  MechanicalControlDevice,
  PlumbingEquipment,
  HideBoundaryOpenEnds,
  ShowLastReport,
  GraphicalColumnSchedule,
  ApplyCoping,
  RemoveCoping,
  BeamSystemSymbol,
  StructuralAreaReinforcement,
  AreaReinforcementSymbol,
  SolidSweptBlend,
  VoidSweptBlend,
  EditRebarCover,
  ColorSchemes,
  TrimOrExtendToCorner,
  TrimOrExtendSingleElement,
  TrimOrExtendMultipleElements,
  AlignedDimension,
  LinearDimension,
  AngularDimension,
  RadialDimension,
  ArcLengthDimension,
  MeasureBetweenTwoReferences,
  MeasureAlongAnElement,
  MirrorDrawAxis,
  KeyboardShortcuts,
  BeamOrColumnJoins,
  SaveAsTemplate,
  SaveAsFamily,
  HalftoneOrUnderlay,
  Multiplanar,
  OpenProject,
  LoadCases,
  LoadCombinations,
  FindOrReplace,
  EnergySettings,
  Generate,
  ExportGBXML,
  GuideGrid,
  CreateAssembly,
  StairTreadOrRiserNumber,
  ManageConnectionToARevitServerAccelerator,
  RenderInCloud,
  RenderGallery,
  CreateEnergyModel,
  DisplaceElements,
  GlobalParameters,
  Collaborate,
  CollaborateInCloud,
  PublishSettings,
  AssemblyCode,
  RevealObstacles,
  PathOfTravel,
  MultipleValuesIndication,
  MultiplePaths,
  OneWayIndicator,
  PeopleContent,
  SpatialGrid,
  LoadFamilyIntoProjectAndClose,
  FabricationPart,
  LoadRebarShapeIntoProjectAndClose,
  Dynamo,
  DeleteEnergyModel,
  Shorten,
  CopeSkewed,
  CornerCut,
  Welds,
  Plate,
  Bolts,
  Holes,
  Anchors,
  ShearStuds,
  ContourCut,
  Cope,
  Miter,
  SawCutFlange,
  SawCutWeb,
  CutThrough,
  CutBy,
  ToggleHome,
  SaveAsCloudModel,
  SystemsAnalysis,
  LinkPDF,
  LinkImage,
  BatchPrint,
  WorksharingMonitor,
  SharedViews,
  ResetSharedCoordinates,
  ElectricalAnalyticalLoadTypeSettings,
  GenerateAnalysis,
  ViewAnalysis,
  OpenCloudModel,
  DynamoPlayerForSteel,
  AnalyticalAutomation,
  SpaceNaming,
  DynamoPlayer,
  RepairCentralModel,
  LinkTopography,
  Optimize,
  OpenRevitFile,
  Close,
  Save,
  SaveAsProject,
  PrintSetup,
  Print,
  PrintPreview,
  CopyToClipboard,
  CutToClipboard,
  PasteFromClipboard,
  TabViews,
  TileViews,
  ExitRevit,
  StatusBar,
}
