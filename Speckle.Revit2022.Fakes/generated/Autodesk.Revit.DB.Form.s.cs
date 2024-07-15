namespace Autodesk.Revit.DB;

public partial class Form : Autodesk.Revit.DB.GenericForm
{
	public Form() {}
	public virtual System.Int32 get_ProfileCurveLoopCount(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ReferenceArray get_CurveLoopReferencesOnProfile(System.Int32 profileIndex,System.Int32 curveLoopIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference get_PathCurveReference(System.Int32 curveIndex) => throw new System.NotImplementedException();
	public virtual System.Int32 GetPathCurveIndexByCurveReference(Autodesk.Revit.DB.Reference curveReference) => throw new System.NotImplementedException();
	public virtual void ConstrainProfiles(System.Int32 primaryProfileIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean IsVertexReference(Autodesk.Revit.DB.Reference vertexReference) => throw new System.NotImplementedException();
	public virtual System.Boolean IsEdgeReference(Autodesk.Revit.DB.Reference edgeReference) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCurveReference(Autodesk.Revit.DB.Reference curveReference) => throw new System.NotImplementedException();
	public virtual System.Boolean IsFaceReference(Autodesk.Revit.DB.Reference faceReference) => throw new System.NotImplementedException();
	public virtual System.Boolean IsReferenceOnlyProfile(System.Int32 profileIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean IsBeginningFace(Autodesk.Revit.DB.Reference faceReference) => throw new System.NotImplementedException();
	public virtual System.Boolean IsEndFace(Autodesk.Revit.DB.Reference faceReference) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSideFace(Autodesk.Revit.DB.Reference faceReference) => throw new System.NotImplementedException();
	public virtual System.Boolean IsAutoCreaseEdge(Autodesk.Revit.DB.Reference edgeReference) => throw new System.NotImplementedException();
	public virtual System.Boolean IsProfileEdge(Autodesk.Revit.DB.Reference curveOrEdgeReference) => throw new System.NotImplementedException();
	public virtual System.Boolean IsConnectingEdge(Autodesk.Revit.DB.Reference edgeReference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ReferenceArray GetControlPoints(Autodesk.Revit.DB.Reference curveOrEdgeOrFaceReference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ReferenceArray GetCurvesAndEdgesReference(Autodesk.Revit.DB.Reference pointReference) => throw new System.NotImplementedException();
	public virtual System.Boolean CanManipulateSubElement(Autodesk.Revit.DB.Reference subElementReference) => throw new System.NotImplementedException();
	public virtual System.Boolean CanManipulateProfile(System.Int32 profileIndex) => throw new System.NotImplementedException();
	public virtual void DeleteSubElement(Autodesk.Revit.DB.Reference subElementReference) => throw new System.NotImplementedException();
	public virtual void DeleteProfile(System.Int32 profileIndex) => throw new System.NotImplementedException();
	public virtual void MoveSubElement(Autodesk.Revit.DB.Reference subElementReference,Autodesk.Revit.DB.XYZ offset) => throw new System.NotImplementedException();
	public virtual void MoveProfile(System.Int32 profileIndex,Autodesk.Revit.DB.XYZ offset) => throw new System.NotImplementedException();
	public virtual void RotateSubElement(Autodesk.Revit.DB.Reference subElementReference,Autodesk.Revit.DB.Line axis,System.Double angle) => throw new System.NotImplementedException();
	public virtual void RotateProfile(System.Int32 profileIndex,Autodesk.Revit.DB.Line axis,System.Double angle) => throw new System.NotImplementedException();
	public virtual void ScaleSubElement(Autodesk.Revit.DB.Reference subElementReference,System.Double factor,Autodesk.Revit.DB.XYZ origin) => throw new System.NotImplementedException();
	public virtual void ScaleProfile(System.Int32 profileIndex,System.Double factor,Autodesk.Revit.DB.XYZ origin) => throw new System.NotImplementedException();
	public virtual void AddEdge(Autodesk.Revit.DB.Reference startPointReference,Autodesk.Revit.DB.Reference endPointReference) => throw new System.NotImplementedException();
	public virtual void AddEdge(Autodesk.Revit.DB.Reference startEdgeReference,System.Double startParam,Autodesk.Revit.DB.Reference endEdgeReference,System.Double endParam) => throw new System.NotImplementedException();
	public virtual void AddEdge(Autodesk.Revit.DB.Reference faceReference,Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual System.Int32 AddProfile(Autodesk.Revit.DB.Reference edgeReference,System.Double param) => throw new System.NotImplementedException();
	public virtual void Rehost(Autodesk.Revit.DB.SketchPlane sketchPlane,Autodesk.Revit.DB.XYZ location) => throw new System.NotImplementedException();
	public virtual void Rehost(Autodesk.Revit.DB.Reference hostRef,Autodesk.Revit.DB.XYZ location) => throw new System.NotImplementedException();
	public virtual System.Double BaseOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double TopOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HasOpenGeometry
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean AreProfilesConstrained
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsInXRayMode
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HasOneOrMoreReferenceProfiles
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 PathCurveCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 ProfileCount
	{
		get => throw new System.NotImplementedException();
	}
}
