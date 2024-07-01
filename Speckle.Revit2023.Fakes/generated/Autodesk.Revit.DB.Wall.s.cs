namespace Autodesk.Revit.DB;

public partial class Wall : Autodesk.Revit.DB.HostObject
{
	public virtual Autodesk.Revit.DB.Sketch CreateProfileSketch() => throw new System.NotImplementedException();
	public virtual void RemoveProfileSketch() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetStackedWallMemberIds() => throw new System.NotImplementedException();
	public virtual System.Boolean IsWallCrossSectionValid(Autodesk.Revit.DB.WallCrossSection wallCrossSection) => throw new System.NotImplementedException();
	public virtual void Flip() => throw new System.NotImplementedException();
	public virtual System.Boolean CanHaveProfileSketch() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Wall Create(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> profile,Autodesk.Revit.DB.ElementId wallTypeId,Autodesk.Revit.DB.ElementId levelId,System.Boolean structural,Autodesk.Revit.DB.XYZ normal) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Wall Create(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> profile,Autodesk.Revit.DB.ElementId wallTypeId,Autodesk.Revit.DB.ElementId levelId,System.Boolean structural) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Wall Create(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> profile,System.Boolean structural) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Wall Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Curve curve,Autodesk.Revit.DB.ElementId wallTypeId,Autodesk.Revit.DB.ElementId levelId,System.Double height,System.Double offset,System.Boolean flip,System.Boolean structural) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Wall Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Curve curve,Autodesk.Revit.DB.ElementId levelId,System.Boolean structural) => throw new System.NotImplementedException();
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
	public virtual System.Boolean IsStackedWallMember
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsStackedWall
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Flipped
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Structure.StructuralWallUsage StructuralUsage
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Width
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
