namespace Autodesk.Revit.DB.Electrical;

public partial class ElectricalAnalyticalLoadSet : Autodesk.Revit.DB.Element
{
  public ElectricalAnalyticalLoadSet() { }

  public static Autodesk.Revit.DB.Electrical.ElectricalAnalyticalLoadSet Create(
    Autodesk.Revit.DB.Document document,
    System.String name
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetLoadIds() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 TotalQuantity
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 QuantityOnStandBy
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
