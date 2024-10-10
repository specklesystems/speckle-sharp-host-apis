namespace Rhino.Display;

public partial class DisplayPointSet : System.IDisposable
{
  public DisplayPointSet() { }

  public static Rhino.Display.DisplayPointSet Create(
    System.Collections.Generic.IEnumerable<Rhino.Display.DisplayPoint> points
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();
}
