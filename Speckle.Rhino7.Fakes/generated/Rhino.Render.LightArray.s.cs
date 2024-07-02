namespace Rhino.Render;

public partial class LightArray : System.IDisposable
{
  public LightArray() { }

  public LightArray(System.IntPtr pLightArray) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Light ElementAt(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void Append(Rhino.Geometry.Light light) => throw new System.NotImplementedException();

  public virtual System.Int32 Count() => throw new System.NotImplementedException();

  public virtual System.IntPtr CppPointer
  {
    get => throw new System.NotImplementedException();
  }
}
