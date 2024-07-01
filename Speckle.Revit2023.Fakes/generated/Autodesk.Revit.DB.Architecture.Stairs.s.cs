namespace Autodesk.Revit.DB.Architecture;

public partial class Stairs : Autodesk.Revit.DB.Element
{
  public Stairs() { }

  public virtual System.Boolean IsInEditMode() => throw new System.NotImplementedException();

  public static System.Boolean IsByComponent(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId stairsId
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetStairsRuns() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetStairsLandings() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetStairsSupports() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetAssociatedRailings() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId MultistoryStairsId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumberOfStories
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ActualTreadsNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Height
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double TopElevation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double BaseElevation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 DesiredRisersNumber
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ActualRisersNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ActualTreadDepth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ActualRiserHeight
  {
    get => throw new System.NotImplementedException();
  }
}
