namespace Autodesk.Revit.DB.Electrical;

public partial class WireMaterialType : Autodesk.Revit.DB.ElementType
{
	public virtual Autodesk.Revit.DB.Electrical.TemperatureRatingType AddTemperatureRatingType(System.String name,Autodesk.Revit.DB.Electrical.TemperatureRatingType baseOn) => throw new System.NotImplementedException();
	public virtual void RemoveTemperatureRatingType(Autodesk.Revit.DB.Electrical.TemperatureRatingType temperatureRating) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Electrical.GroundConductorSize AddGroundConductorSize(System.Int64 ampacity,System.String size) => throw new System.NotImplementedException();
	public virtual void RemoveGroundConductorSize(Autodesk.Revit.DB.Electrical.GroundConductorSize grdConductorSize) => throw new System.NotImplementedException();
	public virtual System.Boolean IsInUse
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.GroundConductorSizeSet GroundConductorSizes
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet TemperatureRatings
	{
		get => throw new System.NotImplementedException();
	}
	public new System.String Name
	{
		set {}
	}
}
