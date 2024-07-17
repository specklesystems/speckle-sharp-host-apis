namespace Autodesk.Revit.DB.Structure;

public partial class RebarHookType : Autodesk.Revit.DB.ElementType
{
  public RebarHookType() { }

  public static Autodesk.Revit.DB.Structure.RebarHookType Create(
    Autodesk.Revit.DB.Document doc,
    System.Double angle,
    System.Double multiplier
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsOffsetLengthRequired() => throw new System.NotImplementedException();

  public virtual System.Double GetDefaultHookExtension(System.Double barDiameter) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetHookExtensionLength(Autodesk.Revit.DB.Structure.RebarBarType barType) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId CreateDefaultRebarHookType(Autodesk.Revit.DB.Document ADoc) =>
    throw new System.NotImplementedException();

  public virtual System.Double StraightLineMultiplier
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double HookAngle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.RebarStyle Style
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
