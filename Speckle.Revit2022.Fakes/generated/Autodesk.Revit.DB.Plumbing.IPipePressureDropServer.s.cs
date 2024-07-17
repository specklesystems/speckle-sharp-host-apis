namespace Autodesk.Revit.DB.Plumbing;

public partial interface IPipePressureDropServer
{
  public void Calculate(Autodesk.Revit.DB.Plumbing.PipePressureDropData data);
  public System.String GetInformationLink();
  public System.String GetHtmlDescription();
}
