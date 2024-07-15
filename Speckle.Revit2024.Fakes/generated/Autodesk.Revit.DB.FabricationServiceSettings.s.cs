namespace Autodesk.Revit.DB;

public partial class FabricationServiceSettings : Autodesk.Revit.DB.Element
{
	public FabricationServiceSettings() {}
	public static Autodesk.Revit.DB.FabricationServiceSettings GetFabricationServiceSettings(Autodesk.Revit.DB.Document doc) => throw new System.NotImplementedException();
	public virtual void SetFluidTypeAndTemperature(Autodesk.Revit.DB.FabricationService service,Autodesk.Revit.DB.ElementId fluidId,System.Double temperature) => throw new System.NotImplementedException();
	public virtual void RemoveFluidSetting(Autodesk.Revit.DB.FabricationService service) => throw new System.NotImplementedException();
	public virtual System.Double GetFluidTemperature(Autodesk.Revit.DB.FabricationService service) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetFluidType(Autodesk.Revit.DB.FabricationService service) => throw new System.NotImplementedException();
	public virtual System.Boolean HasValidFluidSetting(Autodesk.Revit.DB.FabricationService service) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ElementId AirFluidType
	{
		get => throw new System.NotImplementedException();
	}
}
