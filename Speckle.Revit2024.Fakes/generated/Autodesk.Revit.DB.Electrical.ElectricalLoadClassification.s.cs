namespace Autodesk.Revit.DB.Electrical;

public partial class ElectricalLoadClassification : Autodesk.Revit.DB.Element
{
  public ElectricalLoadClassification() { }

  public static Autodesk.Revit.DB.Electrical.ElectricalLoadClassification Create(
    Autodesk.Revit.DB.Document ADoc,
    System.String strName
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Spare
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Other
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Motor
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Abbreviation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ActualElectricalLoadLabel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String PanelEstimatedCurrentLabel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String PanelConnectedCurrentLabel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String PanelEstimatedLabel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String PanelConnectedLabel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String LoadSummaryDemandFactorLabel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Electrical.ElectricalLoadClassificationSpace SpaceLoadClass
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId DemandFactorId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
