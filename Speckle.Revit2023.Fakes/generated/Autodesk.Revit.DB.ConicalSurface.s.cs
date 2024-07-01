namespace Autodesk.Revit.DB;

public partial class ConicalSurface : Autodesk.Revit.DB.Surface
{
  public static Autodesk.Revit.DB.ConicalSurface Create(
    Autodesk.Revit.DB.Frame frameOfReference,
    System.Double halfAngle
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Frame GetFrameOfReference() => throw new System.NotImplementedException();

  public static System.Boolean IsValidConeAngle(System.Double halfAngle) => throw new System.NotImplementedException();

  public virtual System.Double HalfAngle
  {
    get => throw new System.NotImplementedException();
  }
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
