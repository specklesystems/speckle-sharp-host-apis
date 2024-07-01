namespace Autodesk.Revit.DB;

public enum BuiltInCategory
{
  INVALID,
  OST_MatchAll,
  OST_MatchModel,
  OST_MatchAnnotation,
  OST_MatchDetail,
  OST_MatchProfile,
  OST_MatchSiteComponent,
  OST_ScheduleViewParamGroup,
  OST_Walls,
  OST_WallsCutOutlines,
  OST_WallsProjectionOutlines,
  OST_WallsAnalyticalGeometry,
  OST_WallsSurfacePattern,
  OST_WallsMembrane,
  OST_WallsStructure,
  OST_WallsInsulation,
  OST_WallsSubstrate,
  OST_WallsFinish1,
  OST_WallsFinish2,
  OST_WallsDefault,
  OST_HiddenWallLines,
  OST_WallsCutPattern,
  OST_RoofsMembrane,
  OST_RoofsStructure,
  OST_RoofsInsulation,
  OST_RoofsSubstrate,
  OST_RoofsFinish1,
  OST_RoofsFinish2,
  OST_RoofsDefault,
  OST_RoofsCutPattern,
  OST_RoofsInteriorEdges,
  OST_FloorsMembrane,
  OST_FloorsStructure,
  OST_FloorsInsulation,
  OST_FloorsSubstrate,
  OST_FloorsFinish1,
  OST_FloorsFinish2,
  OST_FloorsDefault,
  OST_HiddenFloorLines,
  OST_FloorsCutPattern,
  OST_FloorsInteriorEdges,
  OST_CeilingsMembrane,
  OST_CeilingsStructure,
  OST_CeilingsInsulation,
  OST_CeilingsSubstrate,
  OST_CeilingsFinish1,
  OST_CeilingsFinish2,
  OST_CeilingsDefault,
  OST_CeilingsCutPattern,
  OST_WallRefPlanes_Obsolete_IdInWrongRange,
  OST_WallRefPlanes,
  OST_ArcWallRectOpening,
  OST_SWallRectOpening,
  OST_RoofOpening,
  OST_DormerOpeningIncomplete,
  OST_FloorOpening,
  OST_CeilingOpening,
  OST_ShaftOpening,
  OST_StructuralFramingOpening,
  OST_ColumnOpening,
  OST_Windows,
  OST_WindowsGlassCut,
  OST_WindowsGlassProjection,
  OST_WindowsFrameMullionCut,
  OST_WindowsFrameMullionProjection,
  OST_WindowsSillHeadCut,
  OST_WindowsSillHeadProjection,
  OST_WindowsOpeningCut,
  OST_WindowsOpeningProjection,
  OST_Doors,
  OST_DoorsPanelCut,
  OST_DoorsPanelProjection,
  OST_DoorsOpeningCut,
  OST_DoorsOpeningProjection,
  OST_DoorsFrameMullionCut,
  OST_DoorsFrameMullionProjection,
  OST_DoorsGlassCut,
  OST_DoorsGlassProjection,
  OST_Floors,
  OST_FloorsCut,
  OST_FloorsProjection,
  OST_FloorsSurfacePattern,
  OST_FloorsAnalyticalGeometry,
  OST_Roofs,
  OST_RoofsCut,
  OST_RoofsProjection,
  OST_RoofsSurfacePattern,
  OST_Ceilings,
  OST_CeilingsCut,
  OST_CeilingsProjection,
  OST_CeilingsSurfacePattern,
  OST_Lines,
  OST_Curves,
  OST_CurvesThinLines,
  OST_CurvesMediumLines,
  OST_CurvesWideLines,
  OST_SketchLines,
  OST_InvisibleLines,
  OST_AxisOfRotation,
  OST_RoomSeparationLines,
  OST_StairsSketchBoundaryLines,
  OST_StairsSketchRiserLines,
  OST_StairsSketchRunLines,
  OST_StairsSketchLandingCenterLines,
  OST_CloudLines,
  OST_InsulationLines,
  OST_GenericLines,
  OST_AreaSchemeLines,
  OST_RepeatingDetailLines,
  OST_RemovedGridSeg_Obsolete_IdInWrongRange,
  OST_RemovedGridSeg,
  OST_StickSymbols_Obsolete_IdInWrongRange,
  OST_InstanceDrivenLineStyle,
  OST_RoomPolylines,
  OST_AreaPolylines,
  OST_MEPSpaceSeparationLines,
  OST_DimLockControlLeader,
  OST_PathOfTravelLines,
  OST_PathOfTravelTags,
  OST_DividedSurface,
  OST_DividedSurface_Nodes,
  OST_DividedSurface_Gridlines,
  OST_DividedSurface_PatternLines,
  OST_DividedSurface_PatternFill,
  OST_DividedSurface_PreDividedSurface,
  OST_DividedSurface_TransparentFace,
  OST_AlwaysExcludedInAllViews,
  OST_TilePatterns,
  OST_DividedSurfaceBelt,
  OST_DividedSurface_DiscardedDivisionLines,
  OST_FillPatterns,
  OST_Extrusions,
  OST_Furniture,
  OST_Columns,
  OST_Stairs,
  OST_StairsIncomplete_Deprecated,
  OST_StairsAboveCut_ToBeDeprecated,
  OST_StairsStringerCarriage,
  OST_StairsSupportsAboveCut,
  OST_StairsUpText,
  OST_StairsDownText,
  OST_StairsUpArrows,
  OST_StairsDownArrows,
  OST_StairsRailing,
  OST_StairsRailingBaluster,
  OST_StairsRailingRail,
  OST_StairsRailingAboveCut,
  OST_StairsRailingTags,
  OST_Fixtures,
  OST_Rooms,
  OST_RoomInteriorFillVisibility,
  OST_RoomReferenceVisibility,
  OST_AreaInteriorFillVisibility,
  OST_AreaReferenceVisibility,
  OST_AreaColorFill,
  OST_RoomInteriorFill,
  OST_RoomReference,
  OST_AreaInteriorFill,
  OST_AreaReference,
  OST_CurtainWallPanels,
  OST_CurtainWallMullions,
  OST_CurtainWallMullionsCut,
  OST_CurtainGrids,
  OST_CurtainGridsRoof,
  OST_CurtainGridsWall,
  OST_CurtainGridsSystem,
  OST_CurtainGridsCurtaSystem,
  OST_Railings,
  OST_RailingBalusterRail,
  OST_RailingBalusterRailCut,
  OST_Ramps,
  OST_RampsIncomplete,
  OST_RampsAboveCut,
  OST_RampsStringer,
  OST_RampsStringerAboveCut,
  OST_RampsUpText,
  OST_RampsDownText,
  OST_RampsUpArrow,
  OST_RampsDownArrow,
  OST_Cornices,
  OST_Reveals,
  OST_Massing,
  OST_MassingCutOutlines,
  OST_MassingProjectionOutlines,
  OST_FilledRegion,
  OST_PlanRegion,
  OST_FaceSplitter,
  OST_Matchline,
  OST_MaskingRegion,
  OST_ModelText,
  OST_ImportObjectStyles,
  OST_ReferenceViewerSymbol,
  OST_ReferenceViewer,
  OST_HostFin,
  OST_HostFinFloor,
  OST_HostFinRoof,
  OST_HostFinCeiling,
  OST_HostFinWall,
  OST_HostFinHF,
  OST_CurtaSystem,
  OST_CurtaSystemFaceManager,
  OST_AreaReport_Triangle,
  OST_AreaReport_Boundary,
  OST_AreaReport_Arc_Plus,
  OST_AreaReport_Arc_Minus,
  OST_Materials,
  OST_GenericAnnotation,
  OST_GenericModel,
  OST_Casework,
  OST_ElectricalEquipment,
  OST_ElectricalFixtures,
  OST_FurnitureSystems,
  OST_LightingFixtures,
  OST_LightingFixtureSource,
  OST_MechanicalEquipment,
  OST_PlumbingFixtures,
  OST_Parking,
  OST_Property,
  OST_Roads,
  OST_RoadTags,
  OST_Sewer,
  OST_Site,
  OST_SiteSurface,
  OST_SitePoint,
  OST_BuildingPad,
  OST_SiteProperty,
  OST_SitePointBoundary,
  OST_SitePropertyTags,
  OST_SitePropertyLineSegment,
  OST_SitePropertyLineSegmentTags,
  OST_SiteRegion,
  OST_ProjectBasePoint,
  OST_SharedBasePoint,
  OST_BasePointAxisX,
  OST_BasePointAxisY,
  OST_BasePointAxisZ,
  OST_LinkBasePoint,
  OST_StructuralFoundation,
  OST_HiddenStructuralFoundationLines,
  OST_StructuralFraming,
  OST_StructuralFramingOther,
  OST_Girder,
  OST_Joist,
  OST_Purlin,
  OST_HorizontalBracing,
  OST_VerticalBracing,
  OST_StructuralFramingSystem,
  OST_KickerBracing,
  OST_HiddenStructuralFramingLines,
  OST_StructuralColumns,
  OST_FramingAnalyticalGeometry,
  OST_ColumnAnalyticalGeometry,
  OST_AnalyticalRigidLinks,
  OST_HiddenStructuralColumnLines,
  OST_StructuralColumnStickSymbols,
  OST_StructuralTruss,
  OST_TopographyLink,
  OST_Topography,
  OST_TopographySurface,
  OST_TopographyContours,
  OST_SecondaryTopographyContours,
  OST_ColumnAnalyticalRigidLinks,
  OST_SpecialityEquipment,
  OST_Automatic,
  OST_RvtLinks,
  OST_FootingAnalyticalGeometry,
  OST_StructuralStiffener,
  OST_StructuralStiffenerTags,
  OST_StructuralFramingLocationLine,
  OST_StructuralColumnLocationLine,
  OST_StructuralStiffenerHiddenLines,
  OST_Blocks,
  OST_Planting,
  OST_Entourage,
  OST_Fascia,
  OST_Gutter,
  OST_EdgeSlab,
  OST_RoofSoffit,
  OST_DetailComponents,
  OST_ProfileFamilies,
  OST_Sheets,
  OST_ProjectInformation,
  OST_Areas,
  OST_AreaSchemes,
  OST_ZoneSchemes,
  OST_Mass_Obsolete_IdInWrongRange,
  OST_MassFloor_Obsolete_IdInWrongRange,
  OST_MassSurface_Obsolete_IdInWrongRange,
  OST_MassTags_Obsolete_IdInWrongRange,
  OST_Mass,
  OST_MassFloor,
  OST_MassForm,
  OST_MassTags,
  OST_ZoningEnvelope,
  OST_MassCutter,
  OST_MassFaceSplitter,
  OST_HostTemplate,
  OST_MassAreaFaceTags,
  OST_MassZone,
  OST_MassInteriorWall,
  OST_MassExteriorWall,
  OST_MassRoof,
  OST_MassGlazing,
  OST_MassSkylights,
  OST_MassOpening,
  OST_MassShade,
  OST_MassSlab,
  OST_MassExteriorWallUnderground,
  OST_MassWallsAll,
  OST_MassFloorsAll,
  OST_MassGlazingAll,
  OST_StackedWalls_Obsolete_IdInWrongRange,
  OST_StackedWalls,
  OST_MEPSpaces,
  OST_MEPSpaceInteriorFillVisibility,
  OST_MEPSpaceReferenceVisibility,
  OST_MEPSpaceInteriorFill,
  OST_MEPSpaceReference,
  OST_MEPSpaceColorFill,
  OST_Sections,
  OST_SectionLine,
  OST_BrokenSectionLine,
  OST_Grids,
  OST_GridChains,
  OST_DisplacementElements,
  OST_DisplacementPath,
  OST_Levels,
  OST_Dimensions,
  OST_WeakDims,
  OST_Constraints,
  OST_SpotElevations,
  OST_SpotCoordinates,
  OST_SpotSlopes,
  OST_RoofTags,
  OST_Assemblies,
  OST_AssemblyTags,
  OST_Parts,
  OST_PartTags,
  OST_PartHiddenLines,
  OST_Viewers,
  OST_Views,
  OST_TitleBlocks,
  OST_TitleBlockThinLines,
  OST_TitleBlockMediumLines,
  OST_TitleBlockWideLines,
  OST_OverheadLines,
  OST_DemolishedLines,
  OST_HiddenLines,
  OST_LinesBeyond,
  OST_CenterLines,
  OST_DirectionEdgeLines,
  OST_Catalogs,
  OST_Divisions,
  OST_TextNotes,
  OST_SectionBox,
  OST_RenderRegions,
  OST_AnalysisResults,
  OST_AnalysisDisplayStyle,
  OST_ContourLabels,
  OST_SectionHeads,
  OST_SectionHeadThinLines,
  OST_SectionHeadMediumLines,
  OST_SectionHeadWideLines,
  OST_WindowTags,
  OST_DoorTags,
  OST_RoomTags,
  OST_MEPSpaceTags,
  OST_Cameras,
  OST_Camera_Lines,
  OST_Viewports,
  OST_ViewportLabel,
  OST_Lights,
  OST_CLines,
  OST_ReferenceLines,
  OST_AxisX,
  OST_AxisY,
  OST_AxisZ,
  OST_Elev,
  OST_CropBoundary,
  OST_Callouts,
  OST_CalloutHeads,
  OST_CalloutBoundary,
  OST_CalloutLeaderLine,
  OST_AnnotationCrop,
  OST_CropBoundarySpecial,
  OST_AnnotationCropSpecial,
  OST_ColorFillLegends,
  OST_RoomColorFill,
  OST_ColorFillSchema,
  OST_RasterImages,
  OST_ScheduleGraphics,
  OST_Schedules,
  OST_LegendComponents,
  OST_PreviewLegendComponents,
  OST_Tags,
  OST_CaseworkTags,
  OST_CeilingTags,
  OST_ElectricalEquipmentTags,
  OST_ElectricalFixtureTags,
  OST_FurnitureTags,
  OST_FurnitureSystemTags,
  OST_LightingFixtureTags,
  OST_MechanicalEquipmentTags,
  OST_PlumbingFixtureTags,
  OST_WallTags,
  OST_CurtainWallPanelTags,
  OST_GenericModelTags,
  OST_SpecialityEquipmentTags,
  OST_StructuralFramingTags,
  OST_SiteTags,
  OST_ParkingTags,
  OST_StructuralColumnTags,
  OST_StructuralFoundationTags,
  OST_AreaTags,
  OST_PlantingTags,
  OST_MultiCategoryTags,
  OST_StairsTags,
  OST_HostFinTags,
  OST_CurtaSystemTags,
  OST_FloorTags,
  OST_MaterialTags,
  OST_DetailComponentTags,
  OST_KeynoteTags,
  OST_TrussTags,
  OST_StructuralConnectionHandlerTags_Deprecated,
  OST_CurtainWallMullionTags,
  OST_MultiLeaderTag,
  OST_SpotElevSymbols,
  OST_SpotCoordinateSymbols,
  OST_SpotSlopesSymbols,
  OST_SpanDirectionSymbol,
  OST_FootingSpanDirectionSymbol,
  OST_BeamSystemTags,
  OST_Loads,
  OST_PointLoads,
  OST_LineLoads,
  OST_AreaLoads,
  OST_InternalLoads,
  OST_InternalPointLoads,
  OST_InternalLineLoads,
  OST_InternalAreaLoads,
  OST_LoadCases,
  OST_LoadCasesDead,
  OST_LoadCasesLive,
  OST_LoadCasesWind,
  OST_LoadCasesSnow,
  OST_LoadCasesRoofLive,
  OST_LoadCasesAccidental,
  OST_LoadCasesTemperature,
  OST_LoadCasesSeismic,
  OST_PointLoadTags,
  OST_LineLoadTags,
  OST_AreaLoadTags,
  OST_InternalPointLoadTags,
  OST_InternalLineLoadTags,
  OST_InternalAreaLoadTags,
  OST_BoundaryConditions,
  OST_VolumeOfInterest,
  OST_DecalElement,
  OST_DecalType,
  OST_LevelHeads,
  OST_GridHeads,
  OST_ElevationMarks,
  OST_EditCutProfile,
  OST_RevisionClouds,
  OST_Revisions,
  OST_RevisionNumberingSequences,
  OST_RevisionCloudTags,
  OST_StructuralAnnotations,
  OST_StructConnectionSymbols,
  OST_StructuralBracePlanReps,
  OST_DesignOptionSets,
  OST_DesignOptions,
  OST_BridgeAbutments,
  OST_BridgePiers,
  OST_BridgeTowers,
  OST_BridgeCables,
  OST_BridgeArches,
  OST_BridgeDecks,
  OST_BridgeFoundations,
  OST_BridgeGirders,
  OST_BridgeBearings,
  OST_BridgeAbutmentHiddenLines,
  OST_BridgePierHiddenLines,
  OST_BridgeTowerHiddenLines2021_Deprecated,
  OST_BridgeCableHiddenLines2021_Deprecated,
  OST_BridgeArchHiddenLines2021_Deprecated,
  OST_BridgeDeckHiddenLines,
  OST_BridgeFoundationHiddenLines2021_Deprecated,
  OST_BridgeGirderHiddenLines2021_Deprecated,
  OST_BridgeBearingHiddenLines,
  OST_BridgeAbutmentTags,
  OST_BridgePierTags,
  OST_BridgeTowerTags,
  OST_BridgeCableTags,
  OST_BridgeArchTags,
  OST_BridgeDeckTags,
  OST_BridgeFoundationTags,
  OST_BridgeGirderTags,
  OST_BridgeBearingTags,
  OST_AbutmentFoundations,
  OST_AbutmentPiles,
  OST_AbutmentWalls,
  OST_ApproachSlabs,
  OST_AbutmentFoundationTags,
  OST_AbutmentPileTags,
  OST_AbutmentWallTags,
  OST_ApproachSlabTags,
  OST_PierCaps,
  OST_PierCapTags,
  OST_PierColumns,
  OST_PierColumnTags,
  OST_PierPiles,
  OST_PierPileTags,
  OST_PierWalls,
  OST_PierWallTags,
  OST_BridgeFraming,
  OST_BridgeFramingHiddenLines,
  OST_BridgeFramingTags,
  OST_BridgeFramingCrossBracing,
  OST_BridgeFramingDiaphragms,
  OST_BridgeFramingTrusses,
  OST_VibrationManagement,
  OST_VibrationManagementHiddenLines,
  OST_VibrationDampers,
  OST_VibrationDamperTags,
  OST_VibrationIsolators,
  OST_VibrationIsolatorTags,
  OST_ExpansionJoints,
  OST_ExpansionJointHiddenLines,
  OST_ExpansionJointTags,
  OST_StructuralTendons,
  OST_StructuralTendonHiddenLines,
  OST_StructuralTendonTags,
  OST_BridgeFramingCrossBracingTags,
  OST_BridgeFramingDiaphragmTags,
  OST_BridgeFramingTrussTags,
  OST_VibrationManagementTags,
  OST_ConnectorElem,
  OST_ConnectorElemXAxis,
  OST_ConnectorElemYAxis,
  OST_ConnectorElemZAxis,
  OST_DuctColorFillLegends,
  OST_DuctColorFills,
  OST_DuctCurves,
  OST_DuctCurvesCenterLine,
  OST_DuctCurvesContour,
  OST_DuctTags,
  OST_FlexDuctTags,
  OST_DuctFitting,
  OST_DuctTerminal,
  OST_DuctTerminalTags,
  OST_DuctSystem,
  OST_DuctAccessory,
  OST_DuctAccessoryTags,
  OST_FlexDuctCurves,
  OST_FlexDuctCurvesCenterLine,
  OST_FlexDuctCurvesContour,
  OST_FlexDuctCurvesPattern,
  OST_DuctCurvesRiseDrop,
  OST_ElectricalCircuit,
  OST_ElectricalCircuitTags,
  OST_Wire,
  OST_ElectricalVoltage,
  OST_ElecDistributionSys,
  OST_ElectricalDemandFactor,
  OST_PipingSystem,
  OST_PipeCurves,
  OST_PipeCurvesCenterLine,
  OST_PipeCurvesContour,
  OST_PipeTags,
  OST_FlexPipeTags,
  OST_PipeFitting,
  OST_FlexPipeCurves,
  OST_FlexPipeCurvesCenterLine,
  OST_FlexPipeCurvesContour,
  OST_FlexPipeCurvesPattern,
  OST_PipeCurvesRiseDrop,
  OST_PipeAccessory,
  OST_PipeAccessoryTags,
  OST_WireTags,
  OST_PipeColorFillLegends,
  OST_PipeColorFills,
  OST_PipeFittingTags,
  OST_DuctFittingTags,
  OST_DuctCurvesDrop,
  OST_DuctCurvesInsulation,
  OST_DuctCurvesLining,
  OST_FlexDuctCurvesInsulation,
  OST_DuctFittingCenterLine,
  OST_DuctFittingInsulation,
  OST_DuctFittingLining,
  OST_PipeCurvesDrop,
  OST_PipeCurvesInsulation,
  OST_FlexPipeCurvesInsulation,
  OST_PipeFittingCenterLine,
  OST_PipeFittingInsulation,
  OST_WireTickMarks,
  OST_TelephoneDevices,
  OST_TelephoneDeviceTags,
  OST_NurseCallDevices,
  OST_NurseCallDeviceTags,
  OST_SecurityDevices,
  OST_SecurityDeviceTags,
  OST_CommunicationDevices,
  OST_CommunicationDeviceTags,
  OST_DataDevices,
  OST_DataDeviceTags,
  OST_FireAlarmDevices,
  OST_FireAlarmDeviceTags,
  OST_LightingDevices,
  OST_LightingDeviceTags,
  OST_WireHomeRunArrows,
  OST_GbXMLFaces,
  OST_GbXML_SType_Interior,
  OST_GbXML_SType_Exterior,
  OST_GbXML_SType_Shade,
  OST_GbXML_SType_Underground,
  OST_GbXML_Opening,
  OST_RouteCurve,
  OST_RouteCurveMain,
  OST_RouteCurveBranch,
  OST_Sprinklers,
  OST_SprinklerTags,
  OST_SwitchSystem,
  OST_EAConstructions,
  OST_PipeConnections,
  OST_PipeMaterials,
  OST_PipeSchedules,
  OST_Fluids,
  OST_HVAC_Zones,
  OST_HVAC_Zones_Boundary,
  OST_HVAC_Zones_InteriorFill,
  OST_HVAC_Zones_Reference,
  OST_WireMaterials,
  OST_WireInsulations,
  OST_WireTemperatureRatings,
  OST_LayoutPath_Bases,
  OST_ZoneTags,
  OST_HVAC_Zones_ColorFill,
  OST_HVAC_Zones_InteriorFill_Visibility,
  OST_HVAC_Zones_Reference_Visibility,
  OST_HVAC_Load_Space_Types,
  OST_HVAC_Load_Building_Types,
  OST_HVAC_Load_Schedules,
  OST_PipeInsulations,
  OST_DuctInsulations,
  OST_DuctLinings,
  OST_RoutingPreferences,
  OST_CableTrayFitting,
  OST_CableTrayFittingTags,
  OST_ConduitFitting,
  OST_ConduitFittingTags,
  OST_CableTray,
  OST_CableTrayTags,
  OST_Conduit,
  OST_ConduitTags,
  OST_CableTrayRiseDrop,
  OST_CableTrayDrop,
  OST_CableTrayCenterLine,
  OST_ConduitRiseDrop,
  OST_ConduitDrop,
  OST_ConduitCenterLine,
  OST_CableTrayFittingCenterLine,
  OST_ConduitFittingCenterLine,
  OST_ElectricalDemandFactorDefinitions,
  OST_ElectricalLoadClassifications,
  OST_ConduitStandards,
  OST_BranchPanelScheduleTemplates,
  OST_SwitchboardScheduleTemplates,
  OST_DataPanelScheduleTemplates,
  OST_ParamElemElectricalLoadClassification,
  OST_ConduitRun,
  OST_CableTrayRun,
  OST_PanelScheduleGraphics,
  OST_ElectricalInternalCircuits,
  OST_DuctInsulationsTags,
  OST_DuctLiningsTags,
  OST_PipeInsulationsTags,
  OST_DuctSystem_Reference,
  OST_DuctSystem_Reference_Visibility,
  OST_PipingSystem_Reference,
  OST_PipingSystem_Reference_Visibility,
  OST_PlaceHolderDucts,
  OST_PlaceHolderPipes,
  OST_GraphicalWarning_OpenConnector,
  OST_PipeSegments,
  OST_SplitterProfile,
  OST_DivisionProfile,
  OST_gbXML_ExteriorWall,
  OST_gbXML_Roof,
  OST_gbXML_RaisedFloor,
  OST_gbXML_SlabOnGrade,
  OST_gbXML_InteriorWall,
  OST_gbXML_InteriorFloor,
  OST_gbXML_Ceiling,
  OST_gbXML_SurfaceAir,
  OST_gbXML_UndergroundWall,
  OST_gbXML_UndergroundSlab,
  OST_gbXML_UndergroundCeiling,
  OST_gbXML_FixedWindow,
  OST_gbXML_OperableWindow,
  OST_gbXML_FixedSkylight,
  OST_gbXML_OperableSkylight,
  OST_gbXML_SlidingDoor,
  OST_gbXML_NonSlidingDoor,
  OST_gbXML_OpeningAir,
  OST_AnalyticSpaces,
  OST_AnalyticSurfaces,
  OST_gbXML_Shade,
  OST_DivisionRules,
  OST_NumberingSchemas,
  OST_LayoutPathBase_Pipings,
  OST_FabricationDuctwork,
  OST_FabricationDuctworkTags,
  OST_FabricationServiceElements,
  OST_FabricationDuctworkCenterLine,
  OST_LayoutNodes,
  OST_FabricationDuctworkInsulation,
  OST_FabricationPartsTmpGraphicEnd,
  OST_OBSOLETE_FabricationPartsTmpGraphicDrop,
  OST_FabricationPartsTmpGraphicDrag,
  OST_OBSOLETE_FabricationPartsTmpGraphicDropDrag,
  OST_FabricationHangers,
  OST_FabricationHangerTags,
  OST_FabricationDuctworkRise,
  OST_FabricationDuctworkDrop,
  OST_FabricationDuctworkSymbology,
  OST_FabricationPipework,
  OST_FabricationPipeworkTags,
  OST_FabricationPipeworkCenterLine,
  OST_FabricationPipeworkSymbology,
  OST_FabricationContainment,
  OST_FabricationContainmentTags,
  OST_FabricationContainmentCenterLine,
  OST_FabricationContainmentSymbology,
  OST_FabricationPipeworkRise,
  OST_FabricationPipeworkDrop,
  OST_FabricationContainmentRise,
  OST_FabricationContainmentDrop,
  OST_FabricationDuctworkLining,
  OST_FabricationPipeworkInsulation,
  OST_ELECTRICAL_AreaBasedLoads_Boundary,
  OST_ELECTRICAL_AreaBasedLoads_InteriorFill,
  OST_ELECTRICAL_AreaBasedLoads_Reference,
  OST_ELECTRICAL_AreaBasedLoads_ColorFill_Obsolete,
  OST_ELECTRICAL_AreaBasedLoads_InteriorFill_Visibility,
  OST_ELECTRICAL_AreaBasedLoads_Reference_Visibility,
  OST_FabricationDuctworkStiffeners,
  OST_FabricationDuctworkStiffenerTags,
  OST_MEPAncillaries_Obsolete,
  OST_MEPAncillaryFraming,
  OST_MechanicalControlDevices,
  OST_MechanicalControlDeviceTags,
  OST_PlumbingEquipment,
  OST_PlumbingEquipmentTags,
  OST_MEPAncillaryFramingTags,
  OST_Rebar,
  OST_RebarSketchLines,
  OST_RebarLines,
  OST_AreaRein,
  OST_AreaReinSketchOverride,
  OST_AreaReinSpanSymbol,
  OST_AreaReinBoundary,
  OST_AreaReinXVisibility,
  OST_Cage,
  OST_PathRein,
  OST_PathReinSpanSymbol,
  OST_PathReinTags,
  OST_PathReinBoundary,
  OST_RebarShape,
  OST_CoverType,
  OST_RebarCover,
  OST_FabricReinforcement,
  OST_FabricAreas,
  OST_RebarHiddenLines,
  OST_FabricAreaSketchEnvelopeLines,
  OST_FabricAreaSketchSheetsLines,
  OST_RebarTags,
  OST_AreaReinTags,
  OST_FabricReinforcementTags,
  OST_FabricAreaTags,
  OST_RebarSetToggle,
  OST_FabricReinforcementBoundary,
  OST_FabricReinforcementWire,
  OST_FabricReinSpanSymbol,
  OST_FabricAreaBoundary,
  OST_StructConnections,
  OST_StructWeldLines,
  OST_StructConnectionHiddenLines,
  OST_StructConnectionSymbol,
  OST_StructConnectionStale,
  OST_StructConnectionFailed,
  OST_StructConnectionReference,
  OST_StructConnectionProfiles,
  OST_StructConnectionPlates,
  OST_StructConnectionAnchors,
  OST_StructConnectionBolts,
  OST_StructConnectionOthers,
  OST_StructConnectionNobleWarning,
  OST_StructConnectionShearStuds,
  OST_StructConnectionHoles,
  OST_StructConnectionWelds,
  OST_StructConnectionModifiers,
  OST_StructSubConnections,
  OST_StructConnectionTags,
  OST_StructConnectionPlateTags,
  OST_StructConnectionBoltTags,
  OST_StructConnectionAnchorTags,
  OST_StructConnectionShearStudTags,
  OST_StructConnectionWeldTags,
  OST_StructConnectionHoleTags,
  OST_StructConnectionProfilesTags,
  OST_SteelElementStale,
  OST_Coupler,
  OST_CouplerTags,
  OST_CouplerHiddenLines,
  OST_WindowsHiddenLines,
  OST_DoorsHiddenLines,
  OST_RoofsHiddenLines,
  OST_CeilingsHiddenLines,
  OST_LinesHiddenLines,
  OST_FurnitureHiddenLines,
  OST_ColumnsHiddenLines,
  OST_StairsHiddenLines,
  OST_StairsRailingHiddenLines,
  OST_RampsHiddenLines,
  OST_CurtainWallPanelsHiddenLines,
  OST_CurtainWallMullionsHiddenLines,
  OST_GenericModelHiddenLines,
  OST_ShaftOpeningHiddenLines,
  OST_DetailComponentsHiddenLines,
  OST_CaseworkHiddenLines,
  OST_ElectricalEquipmentHiddenLines,
  OST_ElectricalFixturesHiddenLines,
  OST_FurnitureSystemsHiddenLines,
  OST_LightingFixturesHiddenLines,
  OST_MechanicalEquipmentHiddenLines,
  OST_PlumbingFixturesHiddenLines,
  OST_ParkingHiddenLines,
  OST_RoadsHiddenLines,
  OST_SiteHiddenLines,
  OST_StructuralFramingSystemHiddenLines_Obsolete,
  OST_TopographyHiddenLines,
  OST_SpecialityEquipmentHiddenLines,
  OST_PlantingHiddenLines,
  OST_EntourageHiddenLines,
  OST_OBSOLETE_ElemArrayHiddenLines,
  OST_CurtaSystemHiddenLines,
  OST_MassHiddenLines,
  OST_Stairs2012HiddenLines_Deprecated,
  OST_StairRun2012HiddenLines_Deprecated,
  OST_StairLanding2012HiddenLines_Deprecated,
  OST_StairTread2012HiddenLines_Deprecated,
  OST_StairStringer2012HiddenLines_Deprecated,
  OST_RailingSystemHiddenLines_Deprecated,
  OST_RailingSystemSegmentHiddenLines_Deprecated,
  OST_RailingSystemPostHiddenLines_Deprecated,
  OST_RailingSystemBalusterHiddenLines_Deprecated,
  OST_RailingSystemPanelHiddenLines_Deprecated,
  OST_RailingSystemPanelBracketHiddenLines_Deprecated,
  OST_RailingSystemHandRailHiddenLines_Deprecated,
  OST_RailingSystemHandRailBracketHiddenLines_Deprecated,
  OST_RailingSystemTopRailHiddenLines_Deprecated,
  OST_RailingSystemRailHiddenLines_Deprecated,
  OST_RailingSystemTerminationHiddenLines_Deprecated,
  OST_RailingSystemTransitionHiddenLines_Deprecated,
  OST_MechanicalControlDevicesHiddenLines,
  OST_PlumbingEquipmentHiddenLines,
  OST_TrussDummy,
  OST_Truss,
  OST_TrussDiagWebCurve,
  OST_TrussVertWebCurve,
  OST_TrussTopChordCurve,
  OST_TrussBottomChordCurve,
  OST_TrussWeb,
  OST_TrussChord,
  OST_StructuralTrussHiddenLines,
  OST_StructuralTrussStickSymbols,
  OST_SunStudy,
  OST_Sun,
  OST_SunPath1,
  OST_SunPath2,
  OST_CompassInner,
  OST_SunriseText,
  OST_CompassOuter,
  OST_CompassSection,
  OST_SunsetText,
  OST_Analemma,
  OST_SunSurface,
  OST_MultiSurface,
  OST_LightLine,
  OST_CompassSectionFilled,
  OST_CompassPrimaryMonth,
  OST_CompassSecondaryMonth,
  OST_BeamAnalytical,
  OST_BeamStartSegment,
  OST_BeamEndSegment,
  OST_BraceAnalytical,
  OST_BraceStartSegment,
  OST_BraceEndSegment,
  OST_ColumnAnalytical,
  OST_ColumnStartSegment,
  OST_ColumnEndSegment,
  OST_FloorAnalytical,
  OST_WallAnalytical,
  OST_IsolatedFoundationAnalytical,
  OST_WallFoundationAnalytical,
  OST_FoundationSlabAnalytical,
  OST_RigidLinksAnalytical,
  OST_AnalyticalNodes,
  OST_AnalyticalNodes_Points,
  OST_AnalyticalNodes_Planes,
  OST_AnalyticalNodes_Lines,
  OST_BeamAnalyticalTags,
  OST_BraceAnalyticalTags,
  OST_ColumnAnalyticalTags,
  OST_FloorAnalyticalTags,
  OST_WallAnalyticalTags,
  OST_IsolatedFoundationAnalyticalTags,
  OST_WallFoundationAnalyticalTags,
  OST_FoundationSlabAnalyticalTags,
  OST_LinksAnalytical,
  OST_AssemblyOrigin,
  OST_AssemblyOrigin_Points,
  OST_AssemblyOrigin_Planes,
  OST_AssemblyOrigin_Lines,
  OST_AnalyticalMember,
  OST_AnalyticalMemberTags,
  OST_AnalyticalPanel,
  OST_AnalyticalOpening,
  OST_AnalyticalMemberLocalCoordSys,
  OST_AnalyticalPanelLocalCoordSys,
  OST_CutOutlines,
  OST_IOS,
  OST_IOSRegenerationFailure,
  OST_IOSRegeneratedElements,
  OST_IOSBackedUpElements,
  OST_IOSAligningLine,
  OST_IOSAlignmentGraphics,
  OST_IOSConstructionLine,
  OST_IOSDatumPlane,
  OST_IOSFreeSnapLine,
  OST_IOSSuspendedSketch_obsolete,
  OST_IOSSketchGrid,
  OST_IOSFlipControl,
  OST_IOSThinPixel,
  OST_IOSThinPixel_Dot,
  OST_IOSThinPixel_Dash,
  OST_IOSThinPixel_DashDot,
  OST_IOSGhost,
  OST_IOSGroups,
  OST_IOSCrashGraphics,
  OST_IOSCuttingGeometry,
  OST_IOSOpening,
  OST_IOSRoomPerimeterLines,
  OST_IOSNotSilhouette,
  OST_IOSSlabShapeEditorExplitCrease,
  OST_IOSSlabShapeEditorAutoCrease,
  OST_IOSSlabShapeEditorBoundary,
  OST_IOSSlabShapeEditorPointBoundary,
  OST_IOSSlabShapeEditorPointInterior,
  OST_IOSBBoxScreenSize,
  OST_Curtain_Systems,
  OST_IOSArrays,
  OST_IOSMeasureLine,
  OST_IOSWallCoreBoundary,
  OST_IOSSuspendedSketch,
  OST_IOSModelGroups,
  OST_IOSDetailGroups,
  OST_IOSAttachedDetailGroups,
  OST_IOSRoomTagToRoomLines,
  OST_IOSRebarSystemSpanSymbolCtrl,
  OST_IOSFabricReinSpanSymbolCtrl,
  OST_IOSMeasureLineScreenSize,
  OST_EPS_Existing,
  OST_EPS_Demolished,
  OST_EPS_New,
  OST_EPS_Temporary,
  OST_EPS_Future,
  OST_GuideGrid,
  OST_IOS_GeoLocations,
  OST_IOS_GeoSite,
  OST_Phases,
  OST_IOSDragBox,
  OST_IOSDragBoxInverted,
  OST_IOSRoomUpperLowerLines,
  OST_IOSRoomComputationHeight,
  OST_IOSNavWheelPivotBall,
  OST_ReferencePoints,
  OST_ReferencePoints_Points,
  OST_ReferencePoints_Planes,
  OST_ReferencePoints_Lines,
  OST_ReferencePoints_HiddenLines,
  OST_XRayProfileEdge,
  OST_XRaySideEdge,
  OST_XRayPathCurve,
  OST_XRayPathPoint,
  OST_XRayImplicitPathCurve,
  OST_XRayConstrainedProfileEdge,
  OST_ControlAxisX,
  OST_ControlAxisY,
  OST_ControlAxisZ,
  OST_ControlLocal,
  OST_IOSTilePatternGrid,
  OST_StructLocationLineControl,
  OST_AdaptivePoints,
  OST_AdaptivePoints_Points,
  OST_AdaptivePoints_Planes,
  OST_AdaptivePoints_Lines,
  OST_AdaptivePoints_HiddenLines,
  OST_RailingSystem,
  OST_RailingSystemSegment,
  OST_RailingSystemPost,
  OST_RailingSystemBaluster,
  OST_RailingSystemPanel,
  OST_RailingSystemHardware,
  OST_RailingSystemHandRail,
  OST_RailingSystemHandRailBracket,
  OST_RailingSystemTopRail,
  OST_RailingSystemRail,
  OST_RailingSystemTermination,
  OST_RailingSystemTransition,
  OST_RailingSystemTags,
  OST_Stair2012_Deprecated,
  OST_StairsRuns,
  OST_StairsLandings,
  OST_StairsTrisers,
  OST_StairStringer2012_Deprecated,
  OST_AppearanceAsset,
  OST_PropertySet,
  OST_PointClouds,
  OST_IOSRoomCalculationPoint,
  OST_DividedPath,
  OST_ComponentRepeater,
  OST_ComponentRepeaterSlot,
  OST_StairsCutMarks,
  OST_StairsCutMarksAboveCut,
  OST_StairsNosingLines,
  OST_StairsNosingLinesAboveCut,
  OST_StairsOutlines,
  OST_StairsOutlinesAboveCut,
  OST_StairsRiserLines,
  OST_StairsRiserLinesAboveCut,
  OST_StairsPaths,
  OST_StairsPathsAboveCut,
  OST_StairsRunTags,
  OST_StairsLandingTags,
  OST_StairsSupportTags,
  OST_StairsTriserTags,
  OST_StairsTriserNumbers,
  OST_StairsSketchPathLines,
  OST_RailingTopRail,
  OST_RailingHandRail,
  OST_RailingSupport,
  OST_RailingTermination,
  OST_RailingTopRailAboveCut,
  OST_RailingHandRailAboveCut,
  OST_StairsSupports,
  OST_RailingRailPathLines,
  OST_RailingRailPathExtensionLines,
  OST_LinkAnalyticalTags,
  OST_NodeAnalyticalTags,
  OST_AnalyticalPanelTags,
  OST_AnalyticalOpeningTags,
  OST_DSR_LineAndTextAttrCategoryId,
  OST_DSR_LineAndTextAttrFontId,
  OST_DSR_DimStyleTickCategoryId,
  OST_DSR_DimStyleHeavyEndCatId,
  OST_DSR_DimStyleHeavyEndCategoryId,
  OST_DSR_CenterlinePatternCatId,
  OST_DSR_CenterlineTickMarkStyleId,
  OST_DSR_ArrowHeadStyleId,
  OST_DSR_InteriorTickMarkStyleId,
  OST_DSR_LeaderTickMarkStyleId,
  OST_MultiReferenceAnnotations,
  OST_BeamLocalCoordSys,
  OST_ColumnLocalCoordSys,
  OST_BraceLocalCoordSys,
  OST_WallLocalCoordSys,
  OST_FloorLocalCoordSys,
  OST_FndSlabLocalCoordSys,
  OST_CoordinateSystem,
  OST_StructuralConnectionHandler_Deprecated,
  OST_HiddenStructuralConnectionLines_Deprecated,
  OST_MultistoryStairs,
  OST_Coordination_Model,
  OST_AnalyticalPipeConnections,
  OST_AnalyticalPipeConnectionLineSymbol,
  OST_MechanicalEquipmentSet,
  OST_MechanicalEquipmentSetTags,
  OST_MechanicalEquipmentSetBoundaryLines,
  OST_PipeHydronicSeparationSymbols,
  OST_RiseDropSymbols,
  OST_MEPSystemZone,
  OST_MEPSystemZoneBoundary,
  OST_MEPSystemZoneInteriorFill,
  OST_MEPSystemZoneReferenceLines,
  OST_MEPSystemZoneInteriorFillVisibility,
  OST_MEPSystemZoneReferenceLinesVisibility,
  OST_MEPSystemZoneTags,
  OST_MEPAnalyticalAirLoop,
  OST_MEPAnalyticalWaterLoop,
  OST_ZoneEquipment,
  OST_ElectricalCircuitNaming,
  OST_Alignments,
  OST_MajorStations_Deprecated,
  OST_MinorStations_Deprecated,
  OST_AlignmentsTags,
  OST_AlignmentStationLabelSets,
  OST_AlignmentStationLabels,
  OST_ElectricalZoneEquipment_Obsolete,
  OST_ElectricalLoadZoneType,
  OST_ElectricalLoadZoneInstance,
  OST_MEPAnalyticalBus,
  OST_OBSOLETE_MEPAnalyticalElectricalBranch,
  OST_MEPAnalyticalTransferSwitch,
  OST_MEPLoadAreas,
  OST_MEPLoadAreaTags_OBSOLETE,
  OST_ElectricalPowerSource,
  OST_MEPLoadAreaColorFill,
  OST_MEPLoadAreaInteriorFill,
  OST_MEPLoadAreaReference,
  OST_MEPLoadAreaInteriorFillVisibility,
  OST_MEPLoadAreaReferenceVisibility,
  OST_MEPLoadAreaSeparationLines,
  OST_WallNonCoreLayer,
  OST_WallCoreLayer,
  OST_Hardscape,
  OST_HardscapeHiddenLines,
  OST_HardscapeTags,
  OST_TemporaryStructure,
  OST_TemporaryStructureHiddenLines,
  OST_TemporaryStructureTags,
  OST_FoodServiceEquipment,
  OST_FoodServiceEquipmentHiddenLines,
  OST_FoodServiceEquipmentTags,
  OST_MedicalEquipment,
  OST_MedicalEquipmentHiddenLines,
  OST_MedicalEquipmentTags,
  OST_FireProtection,
  OST_FireProtectionHiddenLines,
  OST_FireProtectionTags,
  OST_VerticalCirculation,
  OST_VerticalCirculationHiddenLines,
  OST_VerticalCirculationTags,
  OST_AudioVisualDevices,
  OST_AudioVisualDevicesHiddenLines,
  OST_AudioVisualDeviceTags,
  OST_Signage,
  OST_SignageHiddenLines,
  OST_SignageTags,
  OST_FasciaTags,
  OST_ColumnTags,
  OST_EntourageTags,
  OST_GutterTags,
  OST_HandrailTags,
  OST_PadTags,
  OST_RampTags,
  OST_RoofSoffitTags,
  OST_SlabEdgeTags,
  OST_TopRailTags,
  OST_WallSweepTags,
  OST_ModelGroupTags,
  OST_RvtLinksTags,
  OST_AnalyticalMemberCrossSection,
  OST_FloorsSplitLines,
  OST_ElectricalAnalyticalTransformer,
  OST_ELECTRICAL_AreaBasedLoads_Tags,
  OST_Toposolid,
  OST_ToposolidHiddenLines,
  OST_ToposolidContours,
  OST_ToposolidSecondaryContours,
  OST_ToposolidFoldingLines,
  OST_ToposolidSplitLines,
  OST_ToposolidDefault,
  OST_ToposolidCutPattern,
  OST_ToposolidMembrane,
  OST_ToposolidStructure,
  OST_ToposolidSubstrate,
  OST_ToposolidFinish1,
  OST_ToposolidFinish2,
  OST_ToposolidSurfacePattern,
  OST_ToposolidInsulation,
  OST_ToposolidTags,
  OST_ToposolidOpening,
  OST_ElectricalAnalyticalFeeder,
  OST_ToposolidLink,
  OST_ElectricalLoadSet,
}
