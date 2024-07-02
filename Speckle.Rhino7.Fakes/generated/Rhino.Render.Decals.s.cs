namespace Rhino.Render;

public partial class Decals : System.Collections.Generic.IEnumerable<Rhino.Render.Decal>, System.Collections.IEnumerable
{
  public Decals() { }

  public virtual System.UInt32 Add(Rhino.Render.Decal decal) => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual System.Boolean Remove(Rhino.Render.Decal decal) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Render.Decal> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();
}
