namespace Autodesk.Revit.DB;

public partial class IndependentTag : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.ElementId get_MultiReferenceAnnotationId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TagOrientation get_TagOrientation() => throw new System.NotImplementedException();
	public virtual void set_TagOrientation(Autodesk.Revit.DB.TagOrientation orientation) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_TagHeadPosition() => throw new System.NotImplementedException();
	public virtual void set_TagHeadPosition(Autodesk.Revit.DB.XYZ headPosition) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LeaderEndCondition get_LeaderEndCondition() => throw new System.NotImplementedException();
	public virtual void set_LeaderEndCondition(Autodesk.Revit.DB.LeaderEndCondition leaderendcondition) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LeadersPresentationMode get_LeadersPresentationMode() => throw new System.NotImplementedException();
	public virtual void set_LeadersPresentationMode(Autodesk.Revit.DB.LeadersPresentationMode presentationMode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetLeaderElbow(Autodesk.Revit.DB.Reference referenceTagged) => throw new System.NotImplementedException();
	public virtual void SetLeaderElbow(Autodesk.Revit.DB.Reference referenceTagged,Autodesk.Revit.DB.XYZ elbowPosition) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetLeaderEnd(Autodesk.Revit.DB.Reference referenceTagged) => throw new System.NotImplementedException();
	public virtual void SetLeaderEnd(Autodesk.Revit.DB.Reference referenceTagged,Autodesk.Revit.DB.XYZ pointEnd) => throw new System.NotImplementedException();
}
