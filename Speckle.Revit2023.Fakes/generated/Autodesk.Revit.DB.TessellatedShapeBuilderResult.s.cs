namespace Autodesk.Revit.DB;

public partial class TessellatedShapeBuilderResult : System.IDisposable
{
	public virtual IList<Autodesk.Revit.DB.GeometryObject> GetGeometricalObjects() => throw new System.NotImplementedException();
	public virtual System.Int32 GetNumberOfFaceSets() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.TessellatedBuildIssue> GetIssuesForFaceSet(System.Int32 setIndex) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean AreObjectsAvailable
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.TessellatedShapeBuilderOutcome Outcome
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasInvalidData
	{
		get => throw new System.NotImplementedException();
	}
}
