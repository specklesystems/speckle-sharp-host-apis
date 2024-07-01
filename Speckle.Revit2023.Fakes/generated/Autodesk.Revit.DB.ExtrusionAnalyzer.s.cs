namespace Autodesk.Revit.DB;

public partial class ExtrusionAnalyzer : System.IDisposable
{
  public static Autodesk.Revit.DB.ExtrusionAnalyzer Create(
    Autodesk.Revit.DB.Solid solidGeometry,
    Autodesk.Revit.DB.Plane plane,
    Autodesk.Revit.DB.XYZ direction
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Face GetExtrusionBase() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IDictionary<
    Autodesk.Revit.DB.Face,
    Autodesk.Revit.DB.ExtrusionAnalyzerFaceAlignment
  > CalculateFaceAlignment() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double EndParameter
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double StartParameter
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ ExtrusionDirection
  {
    get => throw new System.NotImplementedException();
  }
}
