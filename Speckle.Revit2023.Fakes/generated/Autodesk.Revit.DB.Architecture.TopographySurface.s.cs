namespace Autodesk.Revit.DB.Architecture;

public partial class TopographySurface : Autodesk.Revit.DB.Element
{
  public TopographySurface() { }

  public static Autodesk.Revit.DB.Architecture.TopographySurface Create(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points,
    System.Collections.Generic.IList<Autodesk.Revit.DB.PolymeshFacet> facets
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Architecture.TopographySurface Create(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points
  ) => throw new System.NotImplementedException();

  public virtual void AddPoints(System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points) =>
    throw new System.NotImplementedException();

  public virtual void DeletePoints(System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points) =>
    throw new System.NotImplementedException();

  public virtual void MovePoint(Autodesk.Revit.DB.XYZ movedPoint, Autodesk.Revit.DB.XYZ targetPoint) =>
    throw new System.NotImplementedException();

  public virtual void MovePoints(
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> movedPoints,
    Autodesk.Revit.DB.XYZ moveVector
  ) => throw new System.NotImplementedException();

  public virtual void ChangePointElevation(Autodesk.Revit.DB.XYZ point, System.Double elevationValue) =>
    throw new System.NotImplementedException();

  public virtual void ChangePointsElevation(
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points,
    System.Double elevationValue
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidRegion(System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points) =>
    throw new System.NotImplementedException();

  public static System.Boolean ArePointsDistinct(System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetPoints() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsBoundaryPoint(Autodesk.Revit.DB.XYZ point) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ContainsPoint(Autodesk.Revit.DB.XYZ point) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetBoundaryPoints() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetInteriorPoints() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> FindPoints(
    Autodesk.Revit.DB.Outline boundingBox
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.SiteSubRegion AsSiteSubRegion() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetHostedSubRegionIds() =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidFaceSet(
    System.Collections.Generic.IList<Autodesk.Revit.DB.PolymeshFacet> facets,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId MaterialId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId AssociatedBuildingPadId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsAssociatedWithBuildingPad
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSiteSubRegion
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean ArePointsEditable
  {
    get => throw new System.NotImplementedException();
  }
}
