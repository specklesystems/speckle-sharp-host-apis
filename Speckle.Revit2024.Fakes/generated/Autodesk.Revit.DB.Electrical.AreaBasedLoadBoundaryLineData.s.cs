namespace Autodesk.Revit.DB.Electrical;

public partial class AreaBasedLoadBoundaryLineData : System.IDisposable
{
  public AreaBasedLoadBoundaryLineData() { }

  public virtual System.Boolean IsLevelWithinRange(Autodesk.Revit.DB.ElementId levelId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsElevationWithinRange(System.Double elev) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetLevelIdsInRange() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId TopLevelId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId BottomLevelId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
