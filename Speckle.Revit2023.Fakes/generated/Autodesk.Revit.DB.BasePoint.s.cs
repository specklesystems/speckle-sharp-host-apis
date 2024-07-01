namespace Autodesk.Revit.DB;

public partial class BasePoint : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.BasePoint GetProjectBasePoint(Autodesk.Revit.DB.Document cda) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.BasePoint GetSurveyPoint(Autodesk.Revit.DB.Document cda) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ SharedPosition
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Clipped
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Position
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsShared
  {
    get => throw new System.NotImplementedException();
  }
}
