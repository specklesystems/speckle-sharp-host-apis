namespace Autodesk.Revit.DB.Structure;

public partial class AreaReinforcement : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.Structure.AreaReinforcement Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Element hostElement,Autodesk.Revit.DB.XYZ majorDirection,Autodesk.Revit.DB.ElementId areaReinforcementTypeId,Autodesk.Revit.DB.ElementId rebarBarTypeId,Autodesk.Revit.DB.ElementId rebarHookTypeId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.AreaReinforcement Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Element hostElement,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curveArray,Autodesk.Revit.DB.XYZ majorDirection,Autodesk.Revit.DB.ElementId areaReinforcementTypeId,Autodesk.Revit.DB.ElementId rebarBarTypeId,Autodesk.Revit.DB.ElementId rebarHookTypeId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetRebarInSystemIds() => throw new System.NotImplementedException();
	public static System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> RemoveAreaReinforcementSystem(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.AreaReinforcement system) => throw new System.NotImplementedException();
	public static System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> ConvertRebarInSystemToRebars(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.AreaReinforcement system) => throw new System.NotImplementedException();
	public virtual System.Int32 GetNumberOfLines(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType layer) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Line GetLineFromLayerAtIndex(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType layer,System.Int32 linePositionIndex) => throw new System.NotImplementedException();
	public virtual void SetLineIncluded(System.Boolean include,Autodesk.Revit.DB.Structure.AreaReinforcementLayerType layer,System.Int32 linePositionIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean IsLineIncluded(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType layer,System.Int32 linePositionIndex) => throw new System.NotImplementedException();
	public virtual void MoveLine(Autodesk.Revit.DB.XYZ translation,Autodesk.Revit.DB.Structure.AreaReinforcementLayerType layer,System.Int32 linePositionIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetMovedLineTransform(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType layer,System.Int32 linePositionIndex) => throw new System.NotImplementedException();
	public virtual void ResetMovedLineTransform(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType layer,System.Int32 linePositionIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetLayerDirection(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType layer) => throw new System.NotImplementedException();
	public virtual System.Boolean IsLayerActive(Autodesk.Revit.DB.Structure.AreaReinforcementLayerType layer) => throw new System.NotImplementedException();
	public virtual void SetLayerActive(System.Boolean active,Autodesk.Revit.DB.Structure.AreaReinforcementLayerType layer) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetBoundaryCurveIds() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetHostId() => throw new System.NotImplementedException();
	public virtual System.Boolean IsUnobscuredInView(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void SetUnobscuredInView(Autodesk.Revit.DB.View view,System.Boolean unobscured) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSolidInView(Autodesk.Revit.DB.View3D view) => throw new System.NotImplementedException();
	public virtual void SetSolidInView(Autodesk.Revit.DB.View3D view,System.Boolean solid) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Direction
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Structure.AreaReinforcementType AreaReinforcementType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double AdditionalBottomCoverOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AdditionalTopCoverOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
