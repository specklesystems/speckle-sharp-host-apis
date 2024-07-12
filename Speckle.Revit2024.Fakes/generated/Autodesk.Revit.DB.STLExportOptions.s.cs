namespace Autodesk.Revit.DB;

public partial class STLExportOptions : Autodesk.Revit.DB.BIMExportOptions
{
  public STLExportOptions() { }

  public STLExportOptions(Autodesk.Revit.DB.ExportResolution resolutionType) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidForSurfaceTolerance(System.Double value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSurfaceToleranceSet() => throw new System.NotImplementedException();

  public static System.Boolean IsValidForNormalTolerance(System.Double value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsNormalToleranceSet() => throw new System.NotImplementedException();

  public static System.Boolean IsValidForMaxEdgeLength(System.Double value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsMaxEdgeLengthSet() => throw new System.NotImplementedException();

  public static System.Boolean IsValidForGridAspectRatio(System.Double value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsGridAspectRatioSet() => throw new System.NotImplementedException();

  public virtual void SetTessellationSettings(Autodesk.Revit.DB.ExportResolution resolutionType) =>
    throw new System.NotImplementedException();

  public virtual System.Double GridAspectRatio
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double MaxEdgeLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double NormalTolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double SurfaceTolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ExportUnit TargetUnit
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportBinary
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
