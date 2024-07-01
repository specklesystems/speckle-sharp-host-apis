namespace Autodesk.Revit.DB;

public partial class WorksharingUtils : System.IDisposable
{
  public static Autodesk.Revit.DB.ModelUpdatesStatus GetModelUpdatesStatus(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.CheckoutStatus GetCheckoutStatus(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> CheckoutElements(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> elementsToCheckout,
    Autodesk.Revit.DB.TransactWithCentralOptions options
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> CheckoutElements(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementsToCheckout
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ISet<Autodesk.Revit.DB.WorksetId> CheckoutWorksets(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.WorksetId> worksetsToCheckout,
    Autodesk.Revit.DB.TransactWithCentralOptions options
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.WorksetId> CheckoutWorksets(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.WorksetId> worksetsToCheckout
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.RelinquishedItems RelinquishOwnership(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.RelinquishOptions generalCategories,
    Autodesk.Revit.DB.TransactWithCentralOptions options
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.WorksetPreview> GetUserWorksetInfo(
    Autodesk.Revit.DB.ModelPath path
  ) => throw new System.NotImplementedException();

  public static void CreateNewLocal(Autodesk.Revit.DB.ModelPath sourcePath, Autodesk.Revit.DB.ModelPath targetPath) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.WorksharingTooltipInfo GetWorksharingTooltipInfo(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
