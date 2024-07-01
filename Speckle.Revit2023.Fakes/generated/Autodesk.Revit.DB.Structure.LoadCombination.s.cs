namespace Autodesk.Revit.DB.Structure;

public partial class LoadCombination : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.Structure.LoadCombination Create(
    Autodesk.Revit.DB.Document document,
    System.String name,
    Autodesk.Revit.DB.Structure.LoadCombinationType type,
    Autodesk.Revit.DB.Structure.LoadCombinationState state
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.LoadCombination Create(
    Autodesk.Revit.DB.Document document,
    System.String name
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetCaseAndCombinationIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetUsageIds() =>
    throw new System.NotImplementedException();

  public virtual void SetUsageIds(System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> usageIds) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.LoadComponent> GetComponents() =>
    throw new System.NotImplementedException();

  public virtual void SetComponents(
    System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.LoadComponent> components
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsThirdPartyGenerated
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Structure.LoadCombinationState State
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.LoadCombinationType Type
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
