namespace Autodesk.Revit.DB;

public partial class PlanTopology : Autodesk.Revit.DB.APIObject
{
  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetRoomIds() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Phase Phase
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.PlanCircuitSet Circuits
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Level Level
  {
    get => throw new System.NotImplementedException();
  }
}
