namespace Rhino.DocObjects;

public partial class SectionStyle : Rhino.DocObjects.ModelComponent
{
  public SectionStyle() { }

  public SectionStyle(Rhino.DocObjects.SectionStyle other) => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Linetype GetBoundaryLinetype() => throw new System.NotImplementedException();

  public virtual void SetBoundaryLinetype(Rhino.DocObjects.Linetype linetype) =>
    throw new System.NotImplementedException();

  public virtual void RemoveBoundaryLinetype() => throw new System.NotImplementedException();

  public new Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.SectionBackgroundFillMode BackgroundFillMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color BackgroundFillColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color BackgroundFillPrintColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean BoundaryVisible
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BoundaryWidthScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color BoundaryColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color BoundaryPrintColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.ObjectSectionFillRule SectionFillRule
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 HatchIndex
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double HatchScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double HatchRotationRadians
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color HatchPatternColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color HatchPatternPrintColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
