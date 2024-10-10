namespace Rhino.Geometry;

public partial class ParticleSystem
  : System.Collections.Generic.IEnumerable<Rhino.Geometry.Particle>,
    System.Collections.IEnumerable
{
  public ParticleSystem() { }

  public virtual System.Boolean Add(Rhino.Geometry.Particle particle) => throw new System.NotImplementedException();

  public virtual void Remove(Rhino.Geometry.Particle particle) => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual void Update() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.Particle> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean DrawRequiresDepthSorting
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DisplaySizesInWorldUnits
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.BoundingBox BoundingBox
  {
    get => throw new System.NotImplementedException();
  }
}
