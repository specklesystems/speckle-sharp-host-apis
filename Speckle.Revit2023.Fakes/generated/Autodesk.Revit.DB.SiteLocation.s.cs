namespace Autodesk.Revit.DB;

public partial class SiteLocation : Autodesk.Revit.DB.ElementType
{
	public SiteLocation() {}
	public virtual System.DateTime ConvertToProjectTime(System.DateTime inputTime) => throw new System.NotImplementedException();
	public virtual System.DateTime ConvertFromProjectTime(System.DateTime projectTime) => throw new System.NotImplementedException();
	public virtual void SetGeoCoordinateSystem(System.String coordSystem) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCompatibleWith(Autodesk.Revit.DB.SiteLocation otherSiteLocation) => throw new System.NotImplementedException();
	public virtual System.String GeoCoordinateSystemDefinition
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String GeoCoordinateSystemId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Elevation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String WeatherStationName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String PlaceName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double TimeZone
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Longitude
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Latitude
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
