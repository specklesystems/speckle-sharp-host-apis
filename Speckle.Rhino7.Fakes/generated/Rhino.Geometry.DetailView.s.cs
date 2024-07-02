namespace Rhino.Geometry;

public partial class DetailView : Rhino.Geometry.GeometryBase
{
	public DetailView() {}
	public virtual System.Boolean SetScale(System.Double modelLength,Rhino.UnitSystem modelUnits,System.Double pageLength,Rhino.UnitSystem pageUnits) => throw new System.NotImplementedException();
	public virtual System.Boolean IsParallelProjection
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsPerspectiveProjection
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsProjectionLocked
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PageToModelRatio
	{
		get => throw new System.NotImplementedException();
	}
}
