namespace Autodesk.Revit.DB.Structure;

public partial class PathReinforcement : Autodesk.Revit.DB.Element
{
	public PathReinforcement() {}
	public static Autodesk.Revit.DB.Structure.PathReinforcement Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Element hostElement,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curveArray,System.Boolean flip,Autodesk.Revit.DB.ElementId pathReinforcementTypeId,Autodesk.Revit.DB.ElementId rebarBarTypeId,Autodesk.Revit.DB.ElementId startRebarHookTypeId,Autodesk.Revit.DB.ElementId endRebarHookTypeId,Autodesk.Revit.DB.ElementId rebarShapeId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.PathReinforcement Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Element hostElement,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curveArray,System.Boolean flip,Autodesk.Revit.DB.ElementId pathReinforcementTypeId,Autodesk.Revit.DB.ElementId rebarBarTypeId,Autodesk.Revit.DB.ElementId startRebarHookTypeId,Autodesk.Revit.DB.ElementId endRebarHookTypeId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ElementId GetOrCreateDefaultRebarShape(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId rebarBarTypeId,Autodesk.Revit.DB.ElementId startRebarHookTypeId,Autodesk.Revit.DB.ElementId endRebarHookTypeId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetRebarInSystemIds() => throw new System.NotImplementedException();
	public static System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> RemovePathReinforcementSystem(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.PathReinforcement system) => throw new System.NotImplementedException();
	public static System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> ConvertRebarInSystemToRebars(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.PathReinforcement system) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetCurveElementIds() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetHostId() => throw new System.NotImplementedException();
	public virtual System.Boolean IsUnobscuredInView(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void SetUnobscuredInView(Autodesk.Revit.DB.View view,System.Boolean unobscured) => throw new System.NotImplementedException();
	public virtual System.Boolean IsAlternatingLayerEnabled() => throw new System.NotImplementedException();
	public static System.Boolean IsValidRebarShapeId(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidPrimaryBarOrientation(Autodesk.Revit.DB.Structure.ReinforcementBarOrientation orientation) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidAlternatingBarOrientation(Autodesk.Revit.DB.Structure.ReinforcementBarOrientation orientation) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId AlternatingBarShapeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId PrimaryBarShapeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AdditionalOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.PathReinforcementType PathReinforcementType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Structure.ReinforcementBarOrientation AlternatingBarOrientation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.ReinforcementBarOrientation PrimaryBarOrientation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
