namespace Autodesk.Revit.DB;

public partial class SunAndShadowSettings : Autodesk.Revit.DB.Element
{
  public virtual System.String GetMatchingPreset() => throw new System.NotImplementedException();

  public virtual System.DateTime GetFrameTime(System.Double frame) => throw new System.NotImplementedException();

  public virtual System.Double GetFrameAltitude(System.Double frame) => throw new System.NotImplementedException();

  public virtual System.Double GetFrameAzimuth(System.Double frame) => throw new System.NotImplementedException();

  public virtual System.DateTime GetSunrise(System.DateTime date) => throw new System.NotImplementedException();

  public virtual System.DateTime GetSunset(System.DateTime date) => throw new System.NotImplementedException();

  public virtual System.Boolean IsAfterStartDateAndTime(System.DateTime time) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsBeforeEndDateAndTime(System.DateTime time) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsFrameValid(System.Double frame) => throw new System.NotImplementedException();

  public virtual System.Boolean IsGroundPlaneLevelValid(Autodesk.Revit.DB.ElementId levelId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsTimeIntervalValid(Autodesk.Revit.DB.SunStudyTimeInterval interval) =>
    throw new System.NotImplementedException();

  public static System.Double CalculateTimeZone(System.Double latitude, System.Double longitude) =>
    throw new System.NotImplementedException();

  public virtual void FitToModel() => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Element GetActiveSunAndShadowSettings(Autodesk.Revit.DB.Document aDocument) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SharesSettings
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId ProjectLocationId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ProjectLocationName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean UsesDST
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double TimeZone
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Longitude
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Latitude
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double GroundPlaneHeight
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.SunStudyTimeInterval TimeInterval
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean RelativeToView
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UsesGroundPlane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SunriseToSunset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId GroundPlaneLevelId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double NumberOfFrames
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ActiveFrame
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.DateTime EndDateAndTime
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.DateTime StartDateAndTime
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.DateTime ActiveFrameTime
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.SunAndShadowType SunAndShadowType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Altitude
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Azimuth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Visible
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
