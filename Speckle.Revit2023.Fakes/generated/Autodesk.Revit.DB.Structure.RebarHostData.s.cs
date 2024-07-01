namespace Autodesk.Revit.DB.Structure;

public partial class RebarHostData : System.IDisposable
{
  public RebarHostData() { }

  public static Autodesk.Revit.DB.Structure.RebarHostData GetRebarHostData(Autodesk.Revit.DB.Element host) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidHost(Autodesk.Revit.DB.Element element) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidHost() => throw new System.NotImplementedException();

  public static System.Boolean IsReferenceContainedByAValidHost(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.Reference reference
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> GetExposedFaces() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsFaceExposed(Autodesk.Revit.DB.Reference face) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarCoverType GetCoverType(Autodesk.Revit.DB.Reference face) =>
    throw new System.NotImplementedException();

  public virtual void SetCoverType(
    Autodesk.Revit.DB.Reference face,
    Autodesk.Revit.DB.Structure.RebarCoverType coverType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarCoverType GetCommonCoverType() =>
    throw new System.NotImplementedException();

  public virtual void SetCommonCoverType(Autodesk.Revit.DB.Structure.RebarCoverType coverType) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.Rebar> GetRebarsInHost() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.AreaReinforcement> GetAreaReinforcementsInHost() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.PathReinforcement> GetPathReinforcementsInHost() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.FabricSheet> GetFabricSheetsInHost() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.FabricArea> GetFabricAreasInHost() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarContainer> GetRebarContainersInHost() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
