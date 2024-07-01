namespace Autodesk.Revit.DB;

public partial class FailureDefinition : System.IDisposable
{
	public static Autodesk.Revit.DB.FailureDefinition CreateFailureDefinition(Autodesk.Revit.DB.FailureDefinitionId id,Autodesk.Revit.DB.FailureSeverity severity,System.String messageString) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureDefinition AddResolutionType(Autodesk.Revit.DB.FailureResolutionType type,System.String caption,System.Type classOfResolution) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureDefinition SetDefaultResolutionType(Autodesk.Revit.DB.FailureResolutionType type) => throw new System.NotImplementedException();
	public virtual System.String GetDescriptionText() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.FailureResolutionType> GetApplicableResolutionTypes() => throw new System.NotImplementedException();
	public virtual System.String GetResolutionCaption(Autodesk.Revit.DB.FailureResolutionType type) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureResolutionType GetDefaultResolutionType() => throw new System.NotImplementedException();
	public virtual System.Boolean HasResolutions() => throw new System.NotImplementedException();
	public virtual System.Boolean IsResolutionApplicable(Autodesk.Revit.DB.FailureResolutionType type) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FailureSeverity Severity
	{
		get => throw new System.NotImplementedException();
	}
}
