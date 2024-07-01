namespace Autodesk.Revit.DB.Architecture;

public partial class BalusterPattern : System.IDisposable
{
  public virtual System.Int32 GetBalusterCount() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.BalusterInfo GetBaluster(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.BalusterInfo DuplicateBaluster(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual void RemoveBaluster(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Length
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Architecture.PatternJustification DistributionJustification
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Architecture.BreakPatternCondition BreakPattern
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ExcessLengthFillSpacing
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId ExcessLengthFillBalusterId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PatternAngle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double EndSpace
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
