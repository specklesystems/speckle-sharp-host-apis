namespace Rhino.Geometry;

public partial class SweepTwoRail
{
  public SweepTwoRail() { }

  public virtual Rhino.Geometry.Brep[] PerformSweep(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    Rhino.Geometry.Curve crossSection
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep[] PerformSweep(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    Rhino.Geometry.Curve crossSection,
    System.Double crossSectionParameterRail1,
    System.Double crossSectionParameterRail2
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep[] PerformSweep(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep[] PerformSweep(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections,
    System.Collections.Generic.IEnumerable<System.Double> crossSectionParameters1,
    System.Collections.Generic.IEnumerable<System.Double> crossSectionParameters2
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep[] PerformSweepRefit(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    Rhino.Geometry.Curve crossSection,
    System.Double refitTolerance
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep[] PerformSweepRefit(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    Rhino.Geometry.Curve crossSection,
    System.Double crossSectionParameterRail1,
    System.Double crossSectionParameterRail2,
    System.Double refitTolerance
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep[] PerformSweepRefit(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections,
    System.Double refitTolerance
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep[] PerformSweepRefit(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections,
    System.Collections.Generic.IEnumerable<System.Double> crossSectionParametersRail1,
    System.Collections.Generic.IEnumerable<System.Double> crossSectionParametersRail2,
    System.Double refitTolerance
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep[] PerformSweepRebuild(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    Rhino.Geometry.Curve crossSection,
    System.Int32 rebuildCount
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep[] PerformSweepRebuild(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    Rhino.Geometry.Curve crossSection,
    System.Double crossSectionParameterRail1,
    System.Double crossSectionParameterRail2,
    System.Int32 rebuildCount
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep[] PerformSweepRebuild(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections,
    System.Int32 rebuildCount
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep[] PerformSweepRebuild(
    Rhino.Geometry.Curve rail1,
    Rhino.Geometry.Curve rail2,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections,
    System.Collections.Generic.IEnumerable<System.Double> crossSectionParametersRail1,
    System.Collections.Generic.IEnumerable<System.Double> crossSectionParametersRail2,
    System.Int32 rebuildCount
  ) => throw new System.NotImplementedException();

  public virtual System.Double SweepTolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double AngleToleranceRadians
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean MaintainHeight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ClosedSweep
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean AutoAdjust
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseLegacySweeper
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
