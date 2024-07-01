namespace Autodesk.Revit.DB.Structure;

public partial class FabricSheet : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.Structure.FabricSheet Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId concreteHostElementId,
    Autodesk.Revit.DB.ElementId fabricSheetTypeId,
    Autodesk.Revit.DB.CurveLoop bendProfile
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.FabricSheet Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Element hostElement,
    Autodesk.Revit.DB.ElementId fabricSheetTypeId
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetWireCenterlines() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetWireCenterlines(
    Autodesk.Revit.DB.Structure.WireDistributionDirection wireDirection
  ) => throw new System.NotImplementedException();

  public virtual void PlaceInHost(Autodesk.Revit.DB.Element hostElement, Autodesk.Revit.DB.Transform transform) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidHost(Autodesk.Revit.DB.Element host) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidHost(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId concreteHostElementId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetSheetLocation() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.FabricRoundingManager GetReinforcementRoundingManager() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveLoop GetBendProfileWithFillets() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveLoop GetBendProfile() => throw new System.NotImplementedException();

  public virtual void SetBendProfile(Autodesk.Revit.DB.CurveLoop bendProfile) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IDictionary<
    Autodesk.Revit.DB.ElementId,
    System.Double
  > GetSegmentParameterIdsAndLengths(System.Boolean rounded) => throw new System.NotImplementedException();

  public virtual void SetSegmentLength(Autodesk.Revit.DB.ElementId segmentParameterId, System.Double value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSolidInView(Autodesk.Revit.DB.View3D view) =>
    throw new System.NotImplementedException();

  public virtual void SetSolidInView(Autodesk.Revit.DB.View3D view, System.Boolean solid) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsUnobscuredInView(Autodesk.Revit.DB.View view) =>
    throw new System.NotImplementedException();

  public virtual void SetUnobscuredInView(Autodesk.Revit.DB.View view, System.Boolean unobscured) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsCoverOffsetValid(System.Double coverOffset) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSingleFabricSheetWithinHost(
    Autodesk.Revit.DB.Element hostElement,
    Autodesk.Revit.DB.Transform transform
  ) => throw new System.NotImplementedException();

  public virtual System.Double CutOverallWidth
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double CutOverallLength
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String FabricNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Structure.FabricHostReference FabricHostReference
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double CoverOffset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.FabricLocation FabricLocation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId FabricAreaOwnerId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double CutSheetMass
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId HostId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsBent
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId SketchId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ BendFinalLoopOrientationVector
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double BentFabricLongitudinalCutLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.BentFabricStraightWiresLocation BentFabricStraightWiresLocation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.BentFabricBendDirection BentFabricBendDirection
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
