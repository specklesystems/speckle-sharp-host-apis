namespace Autodesk.Revit.DB.Analysis;

public partial class MEPAnalyticalNode : System.IDisposable
{
  public MEPAnalyticalNode() { }

  public virtual System.Boolean IsSameNode(Autodesk.Revit.DB.Analysis.MEPAnalyticalNode other) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ Location
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsFlowBlocked
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsFocalNode
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Id
  {
    get => throw new System.NotImplementedException();
  }
}
