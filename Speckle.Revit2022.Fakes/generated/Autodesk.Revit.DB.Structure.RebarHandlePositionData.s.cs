namespace Autodesk.Revit.DB.Structure;

public partial class RebarHandlePositionData : System.IDisposable
{
  public RebarHandlePositionData() { }

  public virtual System.Int32 GetNumberOfBars() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetBarGeometry(System.Int32 barIndex) =>
    throw new System.NotImplementedException();

  public virtual void SetPosition(System.Int32 handleTag, Autodesk.Revit.DB.XYZ position) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetDistributionPath() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
