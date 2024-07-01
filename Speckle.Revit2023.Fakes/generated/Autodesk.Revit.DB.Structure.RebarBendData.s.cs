namespace Autodesk.Revit.DB.Structure;

public partial class RebarBendData : System.IDisposable
{
  public RebarBendData() { }

  public RebarBendData(
    Autodesk.Revit.DB.Structure.RebarBarType barType,
    Autodesk.Revit.DB.Structure.RebarHookType hookType0,
    Autodesk.Revit.DB.Structure.RebarHookType hookType1,
    Autodesk.Revit.DB.Structure.RebarStyle style,
    Autodesk.Revit.DB.Structure.RebarHookOrientation hookOrient0,
    Autodesk.Revit.DB.Structure.RebarHookOrientation hookOrient1
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double HookBendRadius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.RebarHookOrientation HookOrient1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.RebarHookOrientation HookOrient0
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 HookAngle1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 HookAngle0
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double HookLength1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double HookLength0
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BarNominalDiameter
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BarModelDiameter
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BendRadius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
