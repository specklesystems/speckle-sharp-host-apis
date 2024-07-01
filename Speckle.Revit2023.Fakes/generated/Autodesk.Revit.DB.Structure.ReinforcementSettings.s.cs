namespace Autodesk.Revit.DB.Structure;

public partial class ReinforcementSettings : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.Structure.ReinforcementSettings GetReinforcementSettings(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual System.Boolean IsEqual(Autodesk.Revit.DB.Structure.ReinforcementSettings other) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarRoundingManager GetRebarRoundingManager() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.FabricRoundingManager GetFabricRoundingManager() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTag> GetReinforcementAbbreviationTags(Autodesk.Revit.DB.Structure.ReinforcementAbbreviationObjectType objectType) => throw new System.NotImplementedException();
	public virtual System.String GetReinforcementAbbreviationTag(Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType tagType) => throw new System.NotImplementedException();
	public virtual void SetReinforcementAbbreviationTag(Autodesk.Revit.DB.Structure.ReinforcementAbbreviationTagType tagType,System.String abbreviationTag) => throw new System.NotImplementedException();
	public virtual System.String RebarVaryingLengthNumberSuffix
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean NumberVaryingLengthRebarsIndividually
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.RebarPresentationMode RebarPresentationInSection
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.RebarPresentationMode RebarPresentationInView
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean RebarShapeDefinesEndTreatments
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean RebarShapeDefinesHooks
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HostStructuralRebar
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
