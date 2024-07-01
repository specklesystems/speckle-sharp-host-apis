namespace Autodesk.Revit.DB.Structure;

public partial class RebarContainer : Autodesk.Revit.DB.Element,System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.Structure.RebarContainerItem>
{
	public static Autodesk.Revit.DB.Structure.RebarContainer Create(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.Element hostElement,Autodesk.Revit.DB.ElementId rebarContainerTypeId) => throw new System.NotImplementedException();
	public virtual void ClearItems() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarContainerItem AppendItemFromRebar(Autodesk.Revit.DB.Structure.Rebar rebar) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarContainerItem AppendItemFromCurves(Autodesk.Revit.DB.Structure.RebarStyle style,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.Structure.RebarHookType startHook,Autodesk.Revit.DB.Structure.RebarHookType endHook,Autodesk.Revit.DB.XYZ normal,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves,Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrient,Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrient,System.Boolean useExistingShapeIfPossible,System.Boolean createNewShape) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarContainerItem AppendItemFromRebarShape(Autodesk.Revit.DB.Structure.RebarShape rebarShape,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.XYZ origin,Autodesk.Revit.DB.XYZ xVector,Autodesk.Revit.DB.XYZ yVector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarContainerItem AppendItemFromCurvesAndShape(Autodesk.Revit.DB.Structure.RebarShape rebarShape,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.Structure.RebarHookType startHook,Autodesk.Revit.DB.Structure.RebarHookType endHook,Autodesk.Revit.DB.XYZ normal,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves,Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrient,Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrient) => throw new System.NotImplementedException();
	public virtual void RemoveItem(Autodesk.Revit.DB.Structure.RebarContainerItem pItem) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarContainerItem GetItem(System.Int32 itemIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarContainerParameterManager GetParametersManager() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarRoundingManager GetReinforcementRoundingManager() => throw new System.NotImplementedException();
	public virtual System.Boolean HasPresentationOverrides(Autodesk.Revit.DB.View dBView) => throw new System.NotImplementedException();
	public virtual System.Boolean CanApplyPresentationMode(Autodesk.Revit.DB.View dBView) => throw new System.NotImplementedException();
	public virtual void SetItemHiddenStatus(Autodesk.Revit.DB.View view,System.Int32 itemIndex,System.Boolean hide) => throw new System.NotImplementedException();
	public virtual System.Boolean IsItemHidden(Autodesk.Revit.DB.View view,System.Int32 itemIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(Autodesk.Revit.DB.Structure.RebarContainerItem pItem) => throw new System.NotImplementedException();
	public virtual System.Boolean IsUnobscuredInView(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void SetUnobscuredInView(Autodesk.Revit.DB.View view,System.Boolean unobscured) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSolidInView(Autodesk.Revit.DB.View3D view) => throw new System.NotImplementedException();
	public virtual void SetSolidInView(Autodesk.Revit.DB.View3D view,System.Boolean solid) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetHostId() => throw new System.NotImplementedException();
	public virtual void SetHostId(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.ElementId hostId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarContainerIterator GetRebarContainerIterator() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.Structure.RebarContainerItem> GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 ItemsCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean PresentItemsAsSubelements
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String ScheduleMark
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
