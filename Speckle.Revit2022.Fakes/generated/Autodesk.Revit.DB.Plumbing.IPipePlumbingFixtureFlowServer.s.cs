namespace Autodesk.Revit.DB.Plumbing;

public partial interface IPipePlumbingFixtureFlowServer
{
	public  void Calculate(Autodesk.Revit.DB.Plumbing.PipePlumbingFixtureFlowData data);
	public  System.String GetInformationLink();
	public  System.String GetHtmlDescription();
}
