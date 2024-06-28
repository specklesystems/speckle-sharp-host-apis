namespace Autodesk.Revit.DB;

public partial class FailureMessage : System.Object
{
	public virtual Autodesk.Revit.DB.FailureMessage SetFailingElements(ICollection<Autodesk.Revit.DB.ElementId> idsToShow) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureMessage SetFailingElement(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureMessage SetAdditionalElement(Autodesk.Revit.DB.ElementId additionalElement) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureMessage SetAdditionalElements(ICollection<Autodesk.Revit.DB.ElementId> additionalElements) => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetFailingElements() => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetAdditionalElements() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureMessage AddResolution(Autodesk.Revit.DB.FailureResolutionType type,Autodesk.Revit.DB.FailureResolution resolution) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureSeverity GetSeverity() => throw new System.NotImplementedException();
	public virtual System.String GetDescriptionText() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureDefinitionId GetFailureDefinitionId() => throw new System.NotImplementedException();
	public virtual System.String GetDefaultResolutionCaption() => throw new System.NotImplementedException();
	public virtual System.Boolean HasResolutions() => throw new System.NotImplementedException();
	public virtual System.Boolean HasResolutionOfType(Autodesk.Revit.DB.FailureResolutionType type) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
