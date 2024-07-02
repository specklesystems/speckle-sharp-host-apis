namespace Rhino.Render;

public partial class SimulatedTexture : System.IDisposable
{
  public SimulatedTexture() { }

  public SimulatedTexture(Rhino.RhinoDoc doc) => throw new System.NotImplementedException();

  public SimulatedTexture(Rhino.DocObjects.Texture texture) => throw new System.NotImplementedException();

  public SimulatedTexture(Rhino.RhinoDoc doc, Rhino.DocObjects.Texture texture) =>
    throw new System.NotImplementedException();

  public virtual void SetMappingChannelAndProjectionMode(
    Rhino.Render.SimulatedTexture.ProjectionModes pm,
    System.Int32 mappingChannel,
    Rhino.Render.SimulatedTexture.EnvironmentMappingModes emm
  ) => throw new System.NotImplementedException();

  public virtual System.Double UnitsToMeters(System.Double units) => throw new System.NotImplementedException();

  public virtual System.Double UnitsToMeters(Rhino.RhinoDoc doc, System.Double units) =>
    throw new System.NotImplementedException();

  public virtual System.Double MetersToUnits(System.Double units) => throw new System.NotImplementedException();

  public virtual System.Double MetersToUnits(Rhino.RhinoDoc doc, System.Double units) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Texture Texture() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.IntPtr ConstPointer() => throw new System.NotImplementedException();

  public static System.Int32 BitmapSize
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Transform LocalMappingTransform
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Filename
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String OriginalFilename
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector2d Repeat
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector2d Offset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Rotation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Repeating
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MappingChannel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Render.SimulatedTexture.ProjectionModes ProjectionMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean HasTransparentColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.Color4f TransparentColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double TransparentColorSensitivity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Filtered
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
