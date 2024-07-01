namespace Autodesk.Revit.DB;

public partial class SharedParameterElement : Autodesk.Revit.DB.ParameterElement
{
  public static Autodesk.Revit.DB.SharedParameterElement Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ExternalDefinition sharedParameterDefinition
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.SharedParameterElement Lookup(
    Autodesk.Revit.DB.Document document,
    System.Guid guidValue
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean ShouldHideWhenNoValue() => throw new System.NotImplementedException();

  public virtual System.Guid GuidValue
  {
    get => throw new System.NotImplementedException();
  }
}
