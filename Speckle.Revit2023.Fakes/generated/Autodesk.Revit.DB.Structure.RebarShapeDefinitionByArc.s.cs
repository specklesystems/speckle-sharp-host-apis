namespace Autodesk.Revit.DB.Structure;

public partial class RebarShapeDefinitionByArc : Autodesk.Revit.DB.Structure.RebarShapeDefinition
{
	public RebarShapeDefinitionByArc() {}
	public RebarShapeDefinitionByArc(Autodesk.Revit.DB.Document doc,System.Double height,System.Double pitch,System.Int32 baseFinishingTurns,System.Int32 topFinishingTurns) => throw new System.NotImplementedException();
	public RebarShapeDefinitionByArc(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType type) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarShapeConstraint> GetConstraints() => throw new System.NotImplementedException();
	public virtual void SetConstraints(System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarShapeConstraint> constraints) => throw new System.NotImplementedException();
	public virtual void SetArcTypeSpiral(System.Double height,System.Double pitch,System.Int32 baseFinishingTurns,System.Int32 topFinishingTurns) => throw new System.NotImplementedException();
	public virtual void AddConstraintArcLength(Autodesk.Revit.DB.ElementId paramId) => throw new System.NotImplementedException();
	public virtual void AddConstraintRadius(Autodesk.Revit.DB.ElementId paramId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType arcRefType) => throw new System.NotImplementedException();
	public virtual void AddConstraintDiameter(Autodesk.Revit.DB.ElementId paramId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType arcRefType) => throw new System.NotImplementedException();
	public virtual void AddConstraintCircumference(Autodesk.Revit.DB.ElementId paramId,Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType arcRefType) => throw new System.NotImplementedException();
	public virtual void AddConstraintSagittaLength(Autodesk.Revit.DB.ElementId paramId) => throw new System.NotImplementedException();
	public virtual void AddConstraintChordLength(Autodesk.Revit.DB.ElementId paramId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarShapeDefinitionByArcType Type
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
