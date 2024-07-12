namespace Autodesk.Revit.DB;

public partial class HermiteSpline : Autodesk.Revit.DB.Curve
{
  public HermiteSpline() { }

  public static Autodesk.Revit.DB.HermiteSpline Create(
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> controlPoints,
    System.Boolean periodic,
    Autodesk.Revit.DB.HermiteSplineTangents tangents
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.HermiteSpline Create(
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> controlPoints,
    System.Boolean periodic
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DoubleArray Parameters
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> Tangents
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> ControlPoints
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsPeriodic
  {
    get => throw new System.NotImplementedException();
  }
}
