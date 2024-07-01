namespace Autodesk.Revit.DB.Mechanical;

public partial class MEPSection : System.IDisposable
{
  public MEPSection() { }

  public virtual System.Double GetPressureDrop(Autodesk.Revit.DB.ElementId elemId) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetCoefficient(Autodesk.Revit.DB.ElementId elemId) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetSegmentLength(Autodesk.Revit.DB.ElementId segmentId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsMain(Autodesk.Revit.DB.ElementId fittingId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetElementIds() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double FrictionFactor
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ReynoldsNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double TotalCurveLength
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double TotalPressureLoss
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double TotalCoefficient
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double VelocityPressure
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Velocity
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Friction
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double FixtureUnit
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Flow
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Roughness
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Number
  {
    get => throw new System.NotImplementedException();
  }
}
