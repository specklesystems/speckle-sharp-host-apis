namespace Autodesk.Revit.DB;

public partial class ImageInstance : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.XYZ GetLocation(Autodesk.Revit.DB.BoxPlacement placementPoint) => throw new System.NotImplementedException();
	public virtual void SetLocation(Autodesk.Revit.DB.XYZ newLocation,Autodesk.Revit.DB.BoxPlacement placementPoint) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DrawLayer DrawLayer
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
