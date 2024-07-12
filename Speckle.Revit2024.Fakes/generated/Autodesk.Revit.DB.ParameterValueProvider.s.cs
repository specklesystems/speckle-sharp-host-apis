namespace Autodesk.Revit.DB;

public partial class ParameterValueProvider : Autodesk.Revit.DB.FilterableValueProvider
{
  public ParameterValueProvider() { }

  public ParameterValueProvider(Autodesk.Revit.DB.ElementId parameter) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Parameter
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
