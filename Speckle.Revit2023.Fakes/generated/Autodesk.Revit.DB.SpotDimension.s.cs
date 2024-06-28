namespace Autodesk.Revit.DB;

public partial class SpotDimension : Autodesk.Revit.DB.Dimension
{
	public virtual System.Boolean CanFlip() => throw new System.NotImplementedException();
	public virtual void Flip() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ LeaderShoulderPosition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean LeaderHasShoulder
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.SpotDimensionType SpotDimensionType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
