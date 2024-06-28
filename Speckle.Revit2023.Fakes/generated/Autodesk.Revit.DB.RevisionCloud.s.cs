namespace Autodesk.Revit.DB;

public partial class RevisionCloud : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.RevisionCloud Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.View view,Autodesk.Revit.DB.ElementId revisionId,IList<Autodesk.Revit.DB.Curve> curves) => throw new System.NotImplementedException();
	public virtual System.Boolean IsRevisionIssued() => throw new System.NotImplementedException();
	public virtual ISet<Autodesk.Revit.DB.ElementId> GetSheetIds() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.Curve> GetSketchCurves() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId RevisionId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
