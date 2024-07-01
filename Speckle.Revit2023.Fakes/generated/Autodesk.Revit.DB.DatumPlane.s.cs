namespace Autodesk.Revit.DB;

public partial class DatumPlane : Autodesk.Revit.DB.Element
{
	public virtual void ShowBubbleInView(Autodesk.Revit.DB.DatumEnds datumEnd,Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void HideBubbleInView(Autodesk.Revit.DB.DatumEnds datumEnd,Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual System.Boolean IsBubbleVisibleInView(Autodesk.Revit.DB.DatumEnds datumEnd,Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual System.Boolean HasBubbleInView(Autodesk.Revit.DB.DatumEnds datumEnd,Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual System.Boolean CanBeVisibleInView(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DatumExtentType GetDatumExtentTypeInView(Autodesk.Revit.DB.DatumEnds datumEnd,Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void Maximize3DExtents() => throw new System.NotImplementedException();
	public virtual void SetDatumExtentType(Autodesk.Revit.DB.DatumEnds datumEnd,Autodesk.Revit.DB.View view,Autodesk.Revit.DB.DatumExtentType extentMode) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetCurvesInView(Autodesk.Revit.DB.DatumExtentType extentMode,Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void SetCurveInView(Autodesk.Revit.DB.DatumExtentType extentMode,Autodesk.Revit.DB.View view,Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCurveValidInView(Autodesk.Revit.DB.DatumExtentType extentMode,Autodesk.Revit.DB.View view,Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetPropagationViews(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void PropagateToViews(Autodesk.Revit.DB.View view,System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> parallelViews) => throw new System.NotImplementedException();
	public virtual System.Boolean IsLeaderValid(Autodesk.Revit.DB.DatumEnds datumEnd,Autodesk.Revit.DB.View view,Autodesk.Revit.DB.Leader leader) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Leader GetLeader(Autodesk.Revit.DB.DatumEnds datumEnd,Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void SetLeader(Autodesk.Revit.DB.DatumEnds datumEnd,Autodesk.Revit.DB.View view,Autodesk.Revit.DB.Leader pLeader) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Leader AddLeader(Autodesk.Revit.DB.DatumEnds datumEnd,Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
}
