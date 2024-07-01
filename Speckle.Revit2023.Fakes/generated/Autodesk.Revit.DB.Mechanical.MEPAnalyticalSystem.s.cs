namespace Autodesk.Revit.DB.Mechanical;

public partial class MEPAnalyticalSystem : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.Mechanical.MEPAnalyticalSystem Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Mechanical.AnalyticalSystemDomain domain,
    System.String name
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.WaterLoopData GetWaterLoopData() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.AirSystemData GetAirSystemData() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.AnalyticalSystemDomain AnalyticalSystemDomain
  {
    get => throw new System.NotImplementedException();
  }
}
