namespace Autodesk.Revit.DB.Mechanical;

public partial interface IDuctPressureDropServer
{
	public  void Calculate(Autodesk.Revit.DB.Mechanical.DuctPressureDropData data);
	public  System.String GetInformationLink();
	public  System.String GetHtmlDescription();
}
