namespace Autodesk.Revit.DB;

public partial class ImageInstance : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.ImageInstance Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.View view,Autodesk.Revit.DB.ElementId imageTypeId,Autodesk.Revit.DB.ImagePlacementOptions placementOptions) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetLocation(Autodesk.Revit.DB.BoxPlacement placementPoint) => throw new System.NotImplementedException();
	public virtual void SetLocation(Autodesk.Revit.DB.XYZ newLocation,Autodesk.Revit.DB.BoxPlacement placementPoint) => throw new System.NotImplementedException();
	public static System.Boolean IsValidView(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual System.Boolean CanHaveSnaps
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean EnableSnaps
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.DrawLayer DrawLayer
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean LockProportions
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double HeightScale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double WidthScale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Height
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Width
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
