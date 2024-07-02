namespace Rhino.Render;

public partial class TextureEvaluator : System.IDisposable
{
  public TextureEvaluator() { }

  public virtual System.Boolean Initialize() => throw new System.NotImplementedException();

  public virtual Rhino.Display.Color4f GetColor(
    Rhino.Geometry.Point3d uvw,
    Rhino.Geometry.Vector3d duvwdx,
    Rhino.Geometry.Vector3d duvwdy
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();
}
