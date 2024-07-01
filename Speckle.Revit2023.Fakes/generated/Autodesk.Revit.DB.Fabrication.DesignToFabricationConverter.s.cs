namespace Autodesk.Revit.DB.Fabrication;

public partial class DesignToFabricationConverter : System.IDisposable
{
  public DesignToFabricationConverter(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Fabrication.DesignToFabricationConverterResult Convert(
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> selection,
    System.Int32 serviceId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Fabrication.DesignToFabricationMappingResult SetMapForFamilySymbolToFabricationPartType(
    System.Collections.Generic.IDictionary<Autodesk.Revit.DB.ElementId, Autodesk.Revit.DB.ElementId> typeMappings
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Fabrication.PartialFailureResults> GetPartialConvertFailureResults() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetConvertedFabricationParts() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetElementsWithOpenConnector() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IDictionary<
    Autodesk.Revit.DB.ElementId,
    Autodesk.Revit.DB.ElementId
  > GetConvertedFabricationPartsWithInvalidConnections() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IDictionary<
    Autodesk.Revit.DB.ElementId,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId>
  > GetDesignElementAndFabricationPartsWithOpenConnectors() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IDictionary<
    Autodesk.Revit.DB.ElementId,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId>
  > GetDesignElementAndFabricationPartsWithDifferentOffsets() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
