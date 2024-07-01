namespace Autodesk.Revit.DB.Analysis;

public partial class HVACLoadBuildingType : Autodesk.Revit.DB.Analysis.HVACLoadType
{
  public static Autodesk.Revit.DB.Analysis.HVACLoadBuildingType Create(
    Autodesk.Revit.DB.Document document,
    System.String name
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsNameUnique(System.String name) => throw new System.NotImplementedException();

  public static System.Boolean IsNameUnique(Autodesk.Revit.DB.Document document, System.String name) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidTime(System.String hourMinute) => throw new System.NotImplementedException();

  public virtual System.Double UnoccupiedCoolingSetPoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ClosingTime
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String OpeningTime
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String BuildingTypeName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
