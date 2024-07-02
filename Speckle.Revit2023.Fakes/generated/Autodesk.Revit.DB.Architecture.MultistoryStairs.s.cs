namespace Autodesk.Revit.DB.Architecture;

public partial class MultistoryStairs : Autodesk.Revit.DB.Element
{
	public MultistoryStairs() {}
	public static Autodesk.Revit.DB.Architecture.MultistoryStairs Create(Autodesk.Revit.DB.Architecture.Stairs stairs) => throw new System.NotImplementedException();
	public static System.Boolean IsAcceptableForMultistoryStairs(Autodesk.Revit.DB.Architecture.Stairs stairs) => throw new System.NotImplementedException();
	public virtual void ConnectLevels(System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> levelIds) => throw new System.NotImplementedException();
	public virtual void DisconnectLevels(System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> levelIds) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAllStairsIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetStairsPlacementLevels(Autodesk.Revit.DB.Architecture.Stairs stairs) => throw new System.NotImplementedException();
	public virtual System.Boolean IsPinned(Autodesk.Revit.DB.Architecture.Stairs stairs) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAllConnectedLevels() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Architecture.Stairs Unpin(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Architecture.Stairs Pin(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Architecture.Stairs GetStairsOnLevel(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanConnectLevel(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanDisconnectLevel(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId StandardStairsId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ActualTreadDepth
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
