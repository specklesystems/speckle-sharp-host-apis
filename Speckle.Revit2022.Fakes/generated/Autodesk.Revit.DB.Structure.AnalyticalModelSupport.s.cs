namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalModelSupport : System.IDisposable
{
  public AnalyticalModelSupport() { }

  public virtual Autodesk.Revit.DB.Structure.AnalyticalSupportType GetSupportType() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.AnalyticalSupportPriority GetPriority() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetSupportingElement() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Curve GetCurve() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ GetPoint() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Face GetFace() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
