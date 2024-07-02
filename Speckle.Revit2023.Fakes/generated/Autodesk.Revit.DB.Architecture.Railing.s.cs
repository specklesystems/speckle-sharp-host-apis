namespace Autodesk.Revit.DB.Architecture;

public partial class Railing : Autodesk.Revit.DB.Element
{
	public Railing() {}
	public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId multistoryStairsId,Autodesk.Revit.DB.ElementId levelId,Autodesk.Revit.DB.ElementId railingTypeId,Autodesk.Revit.DB.Architecture.RailingPlacementPosition placePosition) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Architecture.Railing Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.CurveLoop curveLoop,Autodesk.Revit.DB.ElementId railingTypeId,Autodesk.Revit.DB.ElementId baseLevelId) => throw new System.NotImplementedException();
	public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId stairsOrRampId,Autodesk.Revit.DB.ElementId railingTypeId,Autodesk.Revit.DB.Architecture.RailingPlacementPosition placePosition) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetPath() => throw new System.NotImplementedException();
	public virtual void SetPath(Autodesk.Revit.DB.CurveLoop curveLoop) => throw new System.NotImplementedException();
	public virtual System.Boolean RailingCanBeHostedByElement(Autodesk.Revit.DB.ElementId hostId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetHandRails() => throw new System.NotImplementedException();
	public virtual void Reset() => throw new System.NotImplementedException();
	public virtual void Flip() => throw new System.NotImplementedException();
	public virtual void RemoveHost() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetMultistoryStairsPlacementLevels() => throw new System.NotImplementedException();
	public virtual void SetMultistoryStairsPlacementLevels(System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> levelIds) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Subelement GetSubelementOnLevel(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual void ResetSupportPosition() => throw new System.NotImplementedException();
	public static System.Boolean IsValidHostForNewRailing(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public static System.Boolean IsValidPathForRailing(Autodesk.Revit.DB.CurveLoop curveLoop) => throw new System.NotImplementedException();
	public virtual System.Boolean CanReset
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsDefault
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId TopRail
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Flipped
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasHost
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId HostId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
