namespace Autodesk.Revit.DB.Analysis;

public partial class PathOfTravel : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.Analysis.PathOfTravel Create(
    Autodesk.Revit.DB.View DBView,
    Autodesk.Revit.DB.XYZ pathStart,
    Autodesk.Revit.DB.XYZ pathEnd
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.PathOfTravel> CreateMultiple(
    Autodesk.Revit.DB.View DBView,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> pathStarts,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> pathEnds
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.PathOfTravel> CreateMapped(
    Autodesk.Revit.DB.View DBView,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> pathStarts,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> pathEnds
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> FindStartsOfLongestPathsFromRooms(
    Autodesk.Revit.DB.View DBView,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> destinationPoints
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> FindEndsOfShortestPaths(
    Autodesk.Revit.DB.View DBView,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> destinationPoints,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> startPoints
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ>> FindShortestPaths(
    Autodesk.Revit.DB.View DBView,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> destinationPoints,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> startPoints
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus Update() =>
    throw new System.NotImplementedException();

  public static System.Int32 UpdateMultiple(
    Autodesk.Revit.DB.Document adoc,
    System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> elementsToUpdate
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetCurves() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetWaypoints() =>
    throw new System.NotImplementedException();

  public virtual void InsertWaypoint(Autodesk.Revit.DB.XYZ waypoint, System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual void SetWaypoint(Autodesk.Revit.DB.XYZ waypoint, System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual void RemoveWaypoint(System.Int32 index) => throw new System.NotImplementedException();

  public static System.Boolean IsInRevealObstaclesMode(Autodesk.Revit.DB.View DBView) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Analysis.PathOfTravelCalculationStatus SetRevealObstaclesMode(
    Autodesk.Revit.DB.View DBView,
    System.Boolean newState
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId LineStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ PathEnd
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ PathStart
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ PathMidpoint
  {
    get => throw new System.NotImplementedException();
  }
}
