namespace Autodesk.Revit.DB;

public partial class RevisionSettings : Autodesk.Revit.DB.Element
{
  public RevisionSettings() { }

  public static Autodesk.Revit.DB.RevisionSettings GetRevisionSettings(Autodesk.Revit.DB.Document ccda) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.NumericRevisionSettings GetNumericRevisionSettings() =>
    throw new System.NotImplementedException();

  public virtual void SetNumericRevisionSettings(Autodesk.Revit.DB.NumericRevisionSettings newSettings) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.AlphanumericRevisionSettings GetAlphanumericRevisionSettings() =>
    throw new System.NotImplementedException();

  public virtual void SetAlphanumericRevisionSettings(Autodesk.Revit.DB.AlphanumericRevisionSettings newSettings) =>
    throw new System.NotImplementedException();

  public static System.Double RoundRevisionCloudSpacing(Autodesk.Revit.DB.Document ccda, System.Double rawValue) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsAcceptableRevisionCloudSpacing(System.Double rawValue) =>
    throw new System.NotImplementedException();

  public virtual System.Double RevisionCloudSpacing
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.RevisionNumbering RevisionNumbering
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
