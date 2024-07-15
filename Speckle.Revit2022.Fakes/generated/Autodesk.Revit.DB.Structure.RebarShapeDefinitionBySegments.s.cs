namespace Autodesk.Revit.DB.Structure;

public partial class RebarShapeDefinitionBySegments : Autodesk.Revit.DB.Structure.RebarShapeDefinition
{
	public RebarShapeDefinitionBySegments() {}
	public RebarShapeDefinitionBySegments(Autodesk.Revit.DB.Document doc,System.Int32 numberOfSegments) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarShapeSegment GetSegment(System.Int32 segmentIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarShapeVertex GetVertex(System.Int32 vertexIndex) => throw new System.NotImplementedException();
	public virtual void SetSegmentFixedDirection(System.Int32 iSegment,System.Double vecCoordX,System.Double vecCoordY) => throw new System.NotImplementedException();
	public virtual void SetSegmentVariableDirection(System.Int32 iSegment) => throw new System.NotImplementedException();
	public virtual void AddConstraintParallelToSegment(System.Int32 iSegment,Autodesk.Revit.DB.ElementId paramId,System.Boolean measureToOutsideOfBend0,System.Boolean measureToOutsideOfBend1) => throw new System.NotImplementedException();
	public virtual void AddConstraintToSegment(System.Int32 iSegment,Autodesk.Revit.DB.ElementId paramId,System.Double constraintDirCoordX,System.Double constraintDirCoordY,System.Int32 signOfZCoordOfCrossProductOfConstraintDirBySegmentDir,System.Boolean measureToOutsideOfBend0,System.Boolean measureToOutsideOfBend1) => throw new System.NotImplementedException();
	public virtual void SetSegmentAs180DegreeBend(System.Int32 iSegment,Autodesk.Revit.DB.ElementId paramId,System.Boolean measureToOutsideOfBend) => throw new System.NotImplementedException();
	public virtual void SetSegmentAs180DegreeBend(System.Int32 iSegment) => throw new System.NotImplementedException();
	public virtual void RemoveParameterFromSegment(System.Int32 iSegment,Autodesk.Revit.DB.ElementId paramId) => throw new System.NotImplementedException();
	public virtual void AddBendDefaultRadius(System.Int32 vertexIndex,Autodesk.Revit.DB.Structure.RebarShapeVertexTurn turn,Autodesk.Revit.DB.Structure.RebarShapeBendAngle angle) => throw new System.NotImplementedException();
	public virtual void AddBendVariableRadius(System.Int32 vertexIndex,Autodesk.Revit.DB.Structure.RebarShapeVertexTurn turn,Autodesk.Revit.DB.Structure.RebarShapeBendAngle angle,Autodesk.Revit.DB.ElementId paramId,System.Boolean measureIncludingBarThickness) => throw new System.NotImplementedException();
	public virtual void AddListeningDimensionSegmentToSegment(Autodesk.Revit.DB.ElementId paramId,System.Double constraintDirCoordX,System.Double constraintDirCoordY,System.Int32 iSegment0,System.Int32 iSegment1) => throw new System.NotImplementedException();
	public virtual void AddListeningDimensionBendToBend(Autodesk.Revit.DB.ElementId paramId,System.Double constraintDirCoordX,System.Double constraintDirCoordY,System.Int32 iSegment0,System.Int32 iEnd0,System.Int32 iSegment1,System.Int32 iEnd1) => throw new System.NotImplementedException();
	public virtual void AddListeningDimensionSegmentToBend(Autodesk.Revit.DB.ElementId paramId,System.Double constraintDirCoordX,System.Double constraintDirCoordY,System.Int32 iSegment0,System.Int32 iSegment1,System.Int32 iEnd1) => throw new System.NotImplementedException();
	public virtual System.Int32 MajorSegmentIndex
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 NumberOfVertices
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NumberOfSegments
	{
		get => throw new System.NotImplementedException();
	}
}
