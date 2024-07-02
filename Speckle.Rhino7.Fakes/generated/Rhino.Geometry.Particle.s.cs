namespace Rhino.Geometry;

public partial class Particle
{
  public Particle() { }

  public virtual void Update() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.ParticleSystem ParentSystem
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 Index
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point3d Location
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single Size
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color Color
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 DisplayBitmapIndex
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
