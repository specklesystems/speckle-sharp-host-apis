namespace Autodesk.Revit.DB;

public partial class RevolvedSurface : Autodesk.Revit.DB.Surface
{
  public static Autodesk.Revit.DB.Surface Create(
    Autodesk.Revit.DB.Frame frameOfReference,
    Autodesk.Revit.DB.Curve profileCurve,
    System.Double startAngle,
    System.Double endAngle
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Surface Create(
    Autodesk.Revit.DB.Frame frameOfReference,
    Autodesk.Revit.DB.Curve profileCurve
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Surface Create(
    Autodesk.Revit.DB.XYZ axisBasePoint,
    Autodesk.Revit.DB.XYZ axisDirection,
    Autodesk.Revit.DB.Curve profileCurve,
    System.Double startAngle,
    System.Double endAngle
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Surface Create(
    Autodesk.Revit.DB.XYZ axisBasePoint,
    Autodesk.Revit.DB.XYZ axisDirection,
    Autodesk.Revit.DB.Curve profileCurve
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Curve GetProfileCurve() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Curve GetProfileCurveInWorldCoordinates() =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidProfileCurve(
    Autodesk.Revit.DB.Frame frameOfReference,
    Autodesk.Revit.DB.Curve profileCurve
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidProfileCurve(
    Autodesk.Revit.DB.XYZ axisBasePoint,
    Autodesk.Revit.DB.XYZ axisDirection,
    Autodesk.Revit.DB.Curve profileCurve
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ Origin
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ YDir
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ XDir
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ Axis
  {
    get => throw new System.NotImplementedException();
  }
}
