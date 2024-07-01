namespace Autodesk.Revit.DB;

public partial class ViewDisplayBackground : System.IDisposable
{
  public static Autodesk.Revit.DB.ViewDisplayBackground CreateGradient(
    Autodesk.Revit.DB.Color skyColor,
    Autodesk.Revit.DB.Color horizonColor,
    Autodesk.Revit.DB.Color groundColor
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ViewDisplayBackground CreateImage(
    System.String imagePath,
    Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags flags,
    Autodesk.Revit.DB.UV imageOffsets,
    Autodesk.Revit.DB.UV imageScales
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ViewDisplayBackground CreateSky() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double VerticalImageScale
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double HorizontalImageScale
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double VerticalImageOffset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double HorizontalImageOffset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ViewDisplayBackgroundImageFlags ImageFlags
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ImagePath
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Color SkyColor
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Color BackgroundColor
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Color GroundColor
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ViewDisplayBackgroundType Type
  {
    get => throw new System.NotImplementedException();
  }
}
