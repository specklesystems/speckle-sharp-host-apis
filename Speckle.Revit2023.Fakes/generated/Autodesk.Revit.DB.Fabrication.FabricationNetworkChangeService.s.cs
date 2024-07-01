namespace Autodesk.Revit.DB.Fabrication;

public partial class FabricationNetworkChangeService : System.IDisposable
{
  public FabricationNetworkChangeService(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult ChangeService(
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> selection,
    System.Int32 serviceId,
    System.Int32 paletteId,
    System.Boolean restrictPalette
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult ChangeService(
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> selection,
    System.Int32 serviceId,
    System.Int32 paletteId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult ChangeSize(
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> selection,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap> fabricationPartSizeMaps
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult ApplyChange() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetStraightsThatWereNotChanged() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetElementsThatFailed() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Fabrication.FabricationNetworkChangeServiceResult SetSelection(
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> selection
  ) => throw new System.NotImplementedException();

  public virtual void SetServiceId(System.Int32 serviceId) => throw new System.NotImplementedException();

  public virtual void SetPaletteId(System.Int32 paletteId) => throw new System.NotImplementedException();

  public virtual void SetRestrictPalette(System.Boolean restrictPalette) => throw new System.NotImplementedException();

  public virtual void SetMapOfInLinePartTypes(
    System.Collections.Generic.IDictionary<
      Autodesk.Revit.DB.ElementId,
      Autodesk.Revit.DB.ElementId
    > fabricationPartTypes
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetInLinePartTypes() =>
    throw new System.NotImplementedException();

  public virtual void SetMapOfSizesForStraights(
    System.Collections.Generic.ISet<Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap> fabricationPartSizeMaps
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.Fabrication.FabricationPartSizeMap> GetMapOfAllSizesForStraights() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
