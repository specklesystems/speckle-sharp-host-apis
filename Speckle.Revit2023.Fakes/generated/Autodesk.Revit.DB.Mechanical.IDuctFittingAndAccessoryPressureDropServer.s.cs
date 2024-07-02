namespace Autodesk.Revit.DB.Mechanical;

public partial interface IDuctFittingAndAccessoryPressureDropServer
{
	public  System.Boolean Calculate(Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData data);
	public  System.Boolean IsApplicable(Autodesk.Revit.DB.Mechanical.DuctFittingAndAccessoryPressureDropData data);
	public  Autodesk.Revit.DB.ExtensibleStorage.Schema GetDataSchema();
}
