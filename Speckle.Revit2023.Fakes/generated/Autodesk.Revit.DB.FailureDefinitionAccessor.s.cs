namespace Autodesk.Revit.DB;

public partial class FailureDefinitionAccessor : System.IDisposable
{
	public virtual Autodesk.Revit.DB.FailureDefinitionId GetId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureSeverity GetSeverity() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.FailureResolutionType> GetApplicableResolutionTypes() => throw new System.NotImplementedException();
	public virtual System.String GetDescriptionText() => throw new System.NotImplementedException();
	public virtual System.String GetResolutionCaption(Autodesk.Revit.DB.FailureResolutionType type) => throw new System.NotImplementedException();
	public virtual void SetDefaultResolutionType(Autodesk.Revit.DB.FailureResolutionType type) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureResolutionType GetDefaultResolutionType() => throw new System.NotImplementedException();
	public virtual System.Boolean HasResolutions() => throw new System.NotImplementedException();
	public virtual System.Boolean IsResolutionApplicable(Autodesk.Revit.DB.FailureResolutionType type) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
