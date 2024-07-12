namespace Autodesk.Revit.DB;

public partial class ContourSetting : System.IDisposable
{
  public ContourSetting() { }

  public virtual Autodesk.Revit.DB.ContourSettingItem AddSingleContour(
    System.Double elevation,
    Autodesk.Revit.DB.ElementId subcategoryId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ContourSettingItem AddContourRange(
    System.Double start,
    System.Double stop,
    System.Double step,
    Autodesk.Revit.DB.ElementId subcategoryId
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 GetItemIndex(Autodesk.Revit.DB.ContourSettingItem item) =>
    throw new System.NotImplementedException();

  public virtual void RemoveItem(Autodesk.Revit.DB.ContourSettingItem item) =>
    throw new System.NotImplementedException();

  public virtual void DisableItem(Autodesk.Revit.DB.ContourSettingItem item) =>
    throw new System.NotImplementedException();

  public virtual void EnableItem(Autodesk.Revit.DB.ContourSettingItem item) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ContourSettingItem> GetContourSettingItems() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
