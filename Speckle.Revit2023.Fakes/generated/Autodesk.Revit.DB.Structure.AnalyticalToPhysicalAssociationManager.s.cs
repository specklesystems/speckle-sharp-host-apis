namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalToPhysicalAssociationManager : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager GetAnalyticalToPhysicalAssociationManager(Autodesk.Revit.DB.Document doc) => throw new System.NotImplementedException();
	public virtual System.Boolean HasAssociation(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual void AddAssociation(Autodesk.Revit.DB.ElementId analyticalElementId,Autodesk.Revit.DB.ElementId physicalElementId) => throw new System.NotImplementedException();
	public virtual void RemoveAssociation(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetAssociatedElementId(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
}
