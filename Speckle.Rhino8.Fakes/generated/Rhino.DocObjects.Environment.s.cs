namespace Rhino.DocObjects;

public partial class Environment : Rhino.Runtime.CommonObject
{
  public Environment() { }

  public virtual System.Drawing.Color BackgroundColor
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.Texture BackgroundImage
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.Environment.BackgroundProjections BackgroundProjection
  {
    get => throw new System.NotImplementedException();
  }
}
