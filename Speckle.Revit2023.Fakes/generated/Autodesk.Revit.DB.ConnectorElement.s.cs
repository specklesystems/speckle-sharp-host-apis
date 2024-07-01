namespace Autodesk.Revit.DB;

public partial class ConnectorElement : Autodesk.Revit.DB.Element, Autodesk.Revit.DB.IConnector
{
  public virtual Autodesk.Revit.DB.ConnectorElement GetLinkedConnectorElement() =>
    throw new System.NotImplementedException();

  public virtual void SetLinkedConnectorElement(Autodesk.Revit.DB.ConnectorElement otherConnector) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ConnectorElement CreatePipeConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Plumbing.PipeSystemType pipeSystemType,
    Autodesk.Revit.DB.Reference planarFace,
    Autodesk.Revit.DB.Edge edge
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ConnectorElement CreatePipeConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Plumbing.PipeSystemType pipeSystemType,
    Autodesk.Revit.DB.Reference planarFace
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ConnectorElement CreateDuctConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Mechanical.DuctSystemType ductSystemType,
    Autodesk.Revit.DB.ConnectorProfileType profileShape,
    Autodesk.Revit.DB.Reference planarFace,
    Autodesk.Revit.DB.Edge edge
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ConnectorElement CreateDuctConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Mechanical.DuctSystemType ductSystemType,
    Autodesk.Revit.DB.ConnectorProfileType profileShape,
    Autodesk.Revit.DB.Reference planarFace
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ConnectorElement CreateElectricalConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Electrical.ElectricalSystemType electricalSystemType,
    Autodesk.Revit.DB.Reference planarFace,
    Autodesk.Revit.DB.Edge edge
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ConnectorElement CreateElectricalConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Electrical.ElectricalSystemType electricalSystemType,
    Autodesk.Revit.DB.Reference planarFace
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ConnectorElement CreateConduitConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Reference planarFace,
    Autodesk.Revit.DB.Edge edge
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ConnectorElement CreateConduitConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Reference planarFace
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ConnectorElement CreateCableTrayConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Reference planarFace,
    Autodesk.Revit.DB.Edge edge
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ConnectorElement CreateCableTrayConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Reference planarFace
  ) => throw new System.NotImplementedException();

  public virtual void AssignAsPrimary() => throw new System.NotImplementedException();

  public virtual System.Boolean IsSystemClassificationValid(
    Autodesk.Revit.DB.MEPSystemClassification systemClassification
  ) => throw new System.NotImplementedException();

  public virtual void FlipDirection() => throw new System.NotImplementedException();

  public virtual void ChangeHostReference(Autodesk.Revit.DB.Reference planarFace, Autodesk.Revit.DB.Edge edge) =>
    throw new System.NotImplementedException();

  public virtual void ChangeHostReference(Autodesk.Revit.DB.Reference planarFace) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ Direction
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.MEPSystemClassification SystemClassification
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsPrimary
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Radius
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Height
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Width
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ConnectorProfileType Shape
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Domain Domain
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ Origin
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Transform CoordinateSystem
  {
    get => throw new System.NotImplementedException();
  }
}
