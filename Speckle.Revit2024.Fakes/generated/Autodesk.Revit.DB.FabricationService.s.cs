namespace Autodesk.Revit.DB;

public partial class FabricationService : System.IDisposable
{
	public FabricationService() {}
	public virtual System.Boolean IsValidPaletteIndex(System.Int32 paletteIndex) => throw new System.NotImplementedException();
	public virtual System.String GetPaletteName(System.Int32 palette) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCompatibleWith(Autodesk.Revit.DB.FabricationService otherService) => throw new System.NotImplementedException();
	public virtual System.Boolean IsPaletteExcluded(System.Int32 paletteIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean SetServicePaletteExclusions(System.Collections.Generic.IList<System.Int32> excludedPalettes) => throw new System.NotImplementedException();
	public virtual void ResetServiceExclusionOverrides() => throw new System.NotImplementedException();
	public virtual void OverrideServiceButtonExclusion(System.Int32 paletteIndex,System.Int32 buttonIndex,System.Boolean exclude) => throw new System.NotImplementedException();
	public virtual System.Int32 GetButtonCount(System.Int32 palette) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidButtonIndex(System.Int32 paletteIndex,System.Int32 buttonIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FabricationServiceButton GetButton(System.Int32 paletteIndex,System.Int32 buttonIndex) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 ServiceId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 PaletteCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String FabricationSystemName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Abbreviation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Name
	{
		get => throw new System.NotImplementedException();
	}
}
