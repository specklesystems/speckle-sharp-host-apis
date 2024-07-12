namespace Autodesk.Revit.DB;

public partial class MEPSystem : Autodesk.Revit.DB.Element
{
  public MEPSystem() { }

  public virtual void Add(Autodesk.Revit.DB.ConnectorSet connectors) => throw new System.NotImplementedException();

  public virtual void Remove(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds) =>
    throw new System.NotImplementedException();

  public virtual void Remove(Autodesk.Revit.DB.ConnectorSet connectors) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.MEPSection GetSectionByIndex(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.MEPSection GetSectionByNumber(System.Int32 sectionNumber) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> GetCriticalPathSectionNumbers() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSystemDividable() => throw new System.NotImplementedException();

  public virtual System.Int32 GetPhysicalNetworksNumber() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> DivideSystem(
    Autodesk.Revit.DB.Document ADoc
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean HasPlaceholders
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasDesignParts
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasFabricationParts
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsMultipleNetwork
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double PressureLossOfCriticalPath
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 SectionsCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsEmpty
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Connector BaseEquipmentConnector
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.FamilyInstance BaseEquipment
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementSet Elements
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ConnectorManager ConnectorManager
  {
    get => throw new System.NotImplementedException();
  }
}
