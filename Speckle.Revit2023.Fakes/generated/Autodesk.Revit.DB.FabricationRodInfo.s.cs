namespace Autodesk.Revit.DB;

public partial class FabricationRodInfo : System.IDisposable
{
	public virtual Autodesk.Revit.DB.LinkElementId GetRodAttachedElementId(System.Int32 rodIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetRodEndPosition(System.Int32 rodIndex) => throw new System.NotImplementedException();
	public virtual void SetRodEndPosition(System.Int32 rodIndex,Autodesk.Revit.DB.XYZ position) => throw new System.NotImplementedException();
	public virtual void AttachToStructure() => throw new System.NotImplementedException();
	public virtual void AttachToHanger(Autodesk.Revit.DB.ElementId hangerId,System.Int32 rodIndex,Autodesk.Revit.DB.XYZ position) => throw new System.NotImplementedException();
	public virtual System.Boolean IsRodLockedWithHost(System.Int32 rodIndex) => throw new System.NotImplementedException();
	public virtual void SetRodLockedWithHost(System.Int32 rodIndex,System.Boolean locked) => throw new System.NotImplementedException();
	public virtual System.Double GetBearerExtension(System.Int32 rodIndex) => throw new System.NotImplementedException();
	public virtual void SetBearerExtension(System.Int32 rodIndex,System.Double length) => throw new System.NotImplementedException();
	public virtual System.Boolean SetRodStructureExtension(System.Int32 rodIndex,System.Double extension) => throw new System.NotImplementedException();
	public virtual System.Double GetRodStructureExtension(System.Int32 rodIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean SetRodLength(System.Int32 rodIndex,System.Double newLength) => throw new System.NotImplementedException();
	public virtual System.Double GetRodLength(System.Int32 rodIndex) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsAttachedToStructure
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 RodCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean CanRodsBeHosted
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
