namespace Autodesk.Revit.DB;

public partial class TemporaryViewModes : Autodesk.Revit.DB.APIObject
{
  public virtual System.String GetCaption(Autodesk.Revit.DB.TemporaryViewMode mode) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsModeActive(Autodesk.Revit.DB.TemporaryViewMode mode) =>
    throw new System.NotImplementedException();

  public virtual void DeactivateMode(Autodesk.Revit.DB.TemporaryViewMode mode) =>
    throw new System.NotImplementedException();

  public virtual void DeactivateAllModes() => throw new System.NotImplementedException();

  public virtual System.Boolean IsModeAvailable(Autodesk.Revit.DB.TemporaryViewMode mode) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsModeEnabled(Autodesk.Revit.DB.TemporaryViewMode mode) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidState(Autodesk.Revit.DB.PreviewFamilyVisibilityMode state) =>
    throw new System.NotImplementedException();

  public virtual void RemoveCustomization() => throw new System.NotImplementedException();

  public virtual System.Boolean IsCustomized() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Color CustomColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String CustomTitle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean RevealHiddenElements
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.WorksharingDisplayMode WorksharingDisplay
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean RevealConstraints
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public static System.Boolean PreviewFamilyVisibilityDefaultUncutState
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public static System.Boolean PreviewFamilyVisibilityDefaultOnState
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.PreviewFamilyVisibilityMode PreviewFamilyVisibility
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
