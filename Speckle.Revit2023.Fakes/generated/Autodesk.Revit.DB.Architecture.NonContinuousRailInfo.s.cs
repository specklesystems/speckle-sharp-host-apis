namespace Autodesk.Revit.DB.Architecture;

public partial class NonContinuousRailInfo : System.IDisposable
{
	public NonContinuousRailInfo() {}
	public virtual System.Boolean IsValidNonContinuousRailHeight(System.Double height) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidNonContinuousRailName(System.String name) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidNonContinuousRailProfile(Autodesk.Revit.DB.ElementId profileId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidNonContinuousRailMaterial(Autodesk.Revit.DB.ElementId materialId) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId MaterialId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId ProfileId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Offset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Height
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Name
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
