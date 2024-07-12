namespace Autodesk.Revit.DB.Plumbing;

public partial class FlexPipe : Autodesk.Revit.DB.MEPCurve
{
  public FlexPipe() { }

  public static Autodesk.Revit.DB.Plumbing.FlexPipe Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId systemTypeId,
    Autodesk.Revit.DB.ElementId pipeTypeId,
    Autodesk.Revit.DB.ElementId levelId,
    Autodesk.Revit.DB.XYZ startTangent,
    Autodesk.Revit.DB.XYZ endTangent,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Plumbing.FlexPipe Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId systemTypeId,
    Autodesk.Revit.DB.ElementId pipeTypeId,
    Autodesk.Revit.DB.ElementId levelId,
    System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsFlexPipeTypeId(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId pipeTypeId
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsPipingSystemTypeId(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId systemTypeId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ EndTangent
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ StartTangent
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> Points
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Plumbing.FlexPipeType FlexPipeType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Plumbing.PipeFlowState FlowState
  {
    get => throw new System.NotImplementedException();
  }
}
