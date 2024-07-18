namespace Autodesk.Revit.DB;

public partial class CylindricalHelix : Autodesk.Revit.DB.Curve
{
  public CylindricalHelix() { }

  public static Autodesk.Revit.DB.CylindricalHelix Create(
    Autodesk.Revit.DB.XYZ basePoint,
    System.Double radius,
    Autodesk.Revit.DB.XYZ xVector,
    Autodesk.Revit.DB.XYZ zVector,
    System.Double pitch,
    System.Double startAngle,
    System.Double endAngle
  ) => throw new System.NotImplementedException();

  public virtual System.Double Height
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsRightHanded
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Pitch
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ ZVector
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ YVector
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ XVector
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Radius
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ BasePoint
  {
    get => throw new System.NotImplementedException();
  }
}
