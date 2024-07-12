namespace Autodesk.Revit.DB;

public partial class AngularDimension : Autodesk.Revit.DB.Dimension
{
  public AngularDimension() { }

  public static Autodesk.Revit.DB.AngularDimension Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.View dbView,
    Autodesk.Revit.DB.Arc arc,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> references,
    Autodesk.Revit.DB.DimensionType dimensionStyle
  ) => throw new System.NotImplementedException();

  public virtual void SetAngularRadius(System.Double radius) => throw new System.NotImplementedException();
}
