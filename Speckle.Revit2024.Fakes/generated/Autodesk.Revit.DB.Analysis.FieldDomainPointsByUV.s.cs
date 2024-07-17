namespace Autodesk.Revit.DB.Analysis;

public partial class FieldDomainPointsByUV : Autodesk.Revit.DB.Analysis.FieldDomainPoints
{
  public FieldDomainPointsByUV() { }

  public FieldDomainPointsByUV(
    System.Collections.Generic.IList<Autodesk.Revit.DB.UV> points,
    System.Collections.Generic.ICollection<System.Double> uCoordinates,
    System.Collections.Generic.ICollection<System.Double> vCoordinates
  ) => throw new System.NotImplementedException();

  public FieldDomainPointsByUV(System.Collections.Generic.IList<Autodesk.Revit.DB.UV> points) =>
    throw new System.NotImplementedException();

  public virtual void SetGridCoordinates(
    System.Collections.Generic.ICollection<System.Double> uCoordinates,
    System.Collections.Generic.ICollection<System.Double> vCoordinates
  ) => throw new System.NotImplementedException();
}
