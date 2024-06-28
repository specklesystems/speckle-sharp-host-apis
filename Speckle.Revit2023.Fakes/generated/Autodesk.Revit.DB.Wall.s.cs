namespace Autodesk.Revit.DB;

public partial class Wall : Autodesk.Revit.DB.HostObject
{
	public virtual Autodesk.Revit.DB.Sketch CreateProfileSketch() => throw new System.NotImplementedException();
	public virtual void RemoveProfileSketch() => throw new System.NotImplementedException();
	public virtual void Flip() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Orientation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.WallCrossSection CrossSection
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId StackedWallOwnerId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.WallType WallType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId SketchId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.CurtainGrid CurtainGrid
	{
		get => throw new System.NotImplementedException();
	}
}
