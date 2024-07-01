namespace Autodesk.Revit.DB.Plumbing;

public partial interface IPipeFittingAndAccessoryPressureDropServer
{
	public  System.Boolean Calculate(Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData data);
	public  System.Boolean IsApplicable(Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryPressureDropData data);
	public  Autodesk.Revit.DB.ExtensibleStorage.Schema GetDataSchema();
}
