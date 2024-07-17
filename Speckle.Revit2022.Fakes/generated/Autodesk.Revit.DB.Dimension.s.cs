namespace Autodesk.Revit.DB;

public partial class Dimension : Autodesk.Revit.DB.Element
{
  public Dimension() { }

  public virtual void ResetTextPosition() => throw new System.NotImplementedException();

  public virtual System.Boolean IsTextPositionAdjustable() => throw new System.NotImplementedException();

  public virtual System.Boolean HasOneSegment() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean AreReferencesAvailable
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ TextPosition
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Origin
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ LeaderEndPosition
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean HasLeader
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ValueOverride
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Below
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Above
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Suffix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Prefix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsLocked
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ValueString
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Nullable<System.Double> Value
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean AreSegmentsEqual
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.DimensionSegmentArray Segments
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumberOfSegments
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.DimensionShape DimensionShape
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.FamilyParameter FamilyLabel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.DimensionType DimensionType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.View View
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Curve Curve
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ReferenceArray References
  {
    get => throw new System.NotImplementedException();
  }
}
