namespace Autodesk.Revit.DB;

public partial class FilledRegionType : Autodesk.Revit.DB.LineAndTextAttrSymbol
{
  public FilledRegionType() { }

  public virtual System.Boolean IsValidForegroundPatternId(Autodesk.Revit.DB.ElementId patternId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidBackgroundPatternId(Autodesk.Revit.DB.ElementId patternId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidSolidFillPatternId(Autodesk.Revit.DB.ElementId patternId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidFillPatternId(Autodesk.Revit.DB.ElementId patternId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidMasking(System.Boolean isMasking) => throw new System.NotImplementedException();

  public static System.Boolean IsValidLineWeight(System.Int32 lineWeight) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Color BackgroundPatternColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Color ForegroundPatternColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 LineWeight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsMasking
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId BackgroundPatternId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId ForegroundPatternId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
