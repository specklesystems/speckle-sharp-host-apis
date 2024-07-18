namespace Autodesk.Revit.UI;

public partial interface IExternalCommandAvailability
{
  public System.Boolean IsCommandAvailable(
    Autodesk.Revit.UI.UIApplication applicationData,
    Autodesk.Revit.DB.CategorySet selectedCategories
  );
}
