namespace Autodesk.Revit.DB;

public partial class WorksharingDisplaySettings : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.WorksharingDisplayGraphicSettings GetGraphicOverrides(Autodesk.Revit.DB.WorksetId worksetId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WorksharingDisplayGraphicSettings GetGraphicOverrides(Autodesk.Revit.DB.ModelUpdatesStatus statusInCentral) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WorksharingDisplayGraphicSettings GetGraphicOverrides(Autodesk.Revit.DB.CheckoutStatus ownershipStatus) => throw new System.NotImplementedException();
	public virtual void SetGraphicOverrides(Autodesk.Revit.DB.WorksetId worksetId,Autodesk.Revit.DB.WorksharingDisplayGraphicSettings overrides) => throw new System.NotImplementedException();
	public virtual void SetGraphicOverrides(Autodesk.Revit.DB.CheckoutStatus status,Autodesk.Revit.DB.WorksharingDisplayGraphicSettings overrides) => throw new System.NotImplementedException();
	public virtual void SetGraphicOverrides(Autodesk.Revit.DB.ModelUpdatesStatus status,Autodesk.Revit.DB.WorksharingDisplayGraphicSettings overrides) => throw new System.NotImplementedException();
}
