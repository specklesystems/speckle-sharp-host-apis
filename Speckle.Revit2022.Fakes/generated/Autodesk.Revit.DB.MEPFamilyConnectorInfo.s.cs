namespace Autodesk.Revit.DB;

public partial class MEPFamilyConnectorInfo : Autodesk.Revit.DB.MEPConnectorInfo
{
  public MEPFamilyConnectorInfo() { }

  public virtual Autodesk.Revit.DB.ParameterValue GetConnectorParameterValue(
    Autodesk.Revit.DB.ElementId connectorParameterId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetAssociateFamilyParameterId(
    Autodesk.Revit.DB.ElementId connectorParameterId
  ) => throw new System.NotImplementedException();
}
