namespace Autodesk.Revit.DB;

public partial class Wall : Autodesk.Revit.DB.HostObject
{
	public virtual Autodesk.Revit.DB.CurtainGrid get_CurtainGrid() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_SketchId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WallType get_WallType() => throw new System.NotImplementedException();
	public virtual void set_WallType(Autodesk.Revit.DB.WallType wallType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_StackedWallOwnerId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WallCrossSection get_CrossSection() => throw new System.NotImplementedException();
	public virtual void set_CrossSection(Autodesk.Revit.DB.WallCrossSection wallCrossSection) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_Orientation() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Sketch CreateProfileSketch() => throw new System.NotImplementedException();
	public virtual void RemoveProfileSketch() => throw new System.NotImplementedException();
	public virtual void Flip() => throw new System.NotImplementedException();
}
