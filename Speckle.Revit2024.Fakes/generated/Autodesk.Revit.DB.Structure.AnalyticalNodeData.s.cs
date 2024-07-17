namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalNodeData : System.IDisposable
{
  public AnalyticalNodeData() { }

  public virtual Autodesk.Revit.DB.Structure.AnalyticalNodeConnectionStatus GetConnectionStatus() =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.AnalyticalNodeData GetAnalyticalNodeData(
    Autodesk.Revit.DB.Element element
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
