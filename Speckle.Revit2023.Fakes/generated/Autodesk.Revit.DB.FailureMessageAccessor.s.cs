namespace Autodesk.Revit.DB;

public partial class FailureMessageAccessor : System.Object
{
	public virtual Autodesk.Revit.DB.FailureDefinitionId GetFailureDefinitionId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureSeverity GetSeverity() => throw new System.NotImplementedException();
	public virtual System.String GetDescriptionText() => throw new System.NotImplementedException();
	public virtual System.Boolean HasResolutions() => throw new System.NotImplementedException();
	public virtual System.Boolean HasResolutionOfType(Autodesk.Revit.DB.FailureResolutionType type) => throw new System.NotImplementedException();
	public virtual System.String GetDefaultResolutionCaption() => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetFailingElementIds() => throw new System.NotImplementedException();
	public virtual System.Int32 GetNumberOfResolutions() => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetAdditionalElementIds() => throw new System.NotImplementedException();
	public virtual void SetCurrentResolutionType(Autodesk.Revit.DB.FailureResolutionType resolutionType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureResolutionType GetCurrentResolutionType() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureMessage CloneFailureMessage() => throw new System.NotImplementedException();
	public virtual System.Boolean ShouldMergeWithMessage(Autodesk.Revit.DB.FailureMessageAccessor messageToMergeWith) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
