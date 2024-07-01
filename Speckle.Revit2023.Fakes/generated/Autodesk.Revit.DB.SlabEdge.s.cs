namespace Autodesk.Revit.DB;

public partial class SlabEdge : Autodesk.Revit.DB.HostedSweep
{
  public SlabEdge() { }

  public virtual Autodesk.Revit.DB.SlabEdgeType SlabEdgeType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
