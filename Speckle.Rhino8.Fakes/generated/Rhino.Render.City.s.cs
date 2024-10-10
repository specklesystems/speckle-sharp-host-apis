namespace Rhino.Render;

public partial class City
{
  public City() { }

  public static Rhino.Render.City FindNearest(System.Double latitude, System.Double longitude) =>
    throw new System.NotImplementedException();

  public static System.Int32 Cities() => throw new System.NotImplementedException();

  public static Rhino.Render.City CityAt(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Latitude
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Longitude
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double TimeZone
  {
    get => throw new System.NotImplementedException();
  }
}
