namespace Autodesk.Revit.DB;

public partial class ReferencePoint : Autodesk.Revit.DB.Element
{
  public ReferencePoint() { }

  public virtual Autodesk.Revit.DB.PointElementReference GetPointElementReference() =>
    throw new System.NotImplementedException();

  public virtual void SetPointElementReference(Autodesk.Revit.DB.PointElementReference pointElementReference) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetCoordinateSystem() => throw new System.NotImplementedException();

  public virtual void SetCoordinateSystem(Autodesk.Revit.DB.Transform coordinateSystem) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveByPointsArray GetInterpolatingCurves() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetCoordinatePlaneReferenceXY() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetCoordinatePlaneReferenceYZ() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetCoordinatePlaneReferenceXZ() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyElementVisibility GetVisibility() =>
    throw new System.NotImplementedException();

  public virtual void SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility visibility) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetHubId() => throw new System.NotImplementedException();

  public virtual System.Boolean ShowNormalReferencePlaneOnly
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.CoordinatePlaneVisibility CoordinatePlaneVisibility
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Visible
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Position
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public new System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
