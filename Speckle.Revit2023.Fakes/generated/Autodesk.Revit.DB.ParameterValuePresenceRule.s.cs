namespace Autodesk.Revit.DB;

public partial class ParameterValuePresenceRule : Autodesk.Revit.DB.FilterRule
{
  public ParameterValuePresenceRule() { }

  public virtual Autodesk.Revit.DB.ElementId Parameter
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
