namespace Autodesk.Revit.DB;

public partial class IndependentTag : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.XYZ GetLeaderElbow(Autodesk.Revit.DB.Reference referenceTagged) => throw new System.NotImplementedException();
	public virtual void SetLeaderElbow(Autodesk.Revit.DB.Reference referenceTagged,Autodesk.Revit.DB.XYZ elbowPosition) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetLeaderEnd(Autodesk.Revit.DB.Reference referenceTagged) => throw new System.NotImplementedException();
	public virtual void SetLeaderEnd(Autodesk.Revit.DB.Reference referenceTagged,Autodesk.Revit.DB.XYZ pointEnd) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LeadersPresentationMode LeadersPresentationMode
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.LeaderEndCondition LeaderEndCondition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ TagHeadPosition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.TagOrientation TagOrientation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId MultiReferenceAnnotationId
	{
		get => throw new System.NotImplementedException();
	}
}
