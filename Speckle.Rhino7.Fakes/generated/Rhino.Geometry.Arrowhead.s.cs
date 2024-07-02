namespace Rhino.Geometry;

public partial class Arrowhead
{
  public Arrowhead() { }

  public Arrowhead(Rhino.DocObjects.DimensionStyle.ArrowType arrowType, System.Guid blockId) =>
    throw new System.NotImplementedException();

  public virtual System.Guid BlockId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.DimensionStyle.ArrowType ArrowType
  {
    get => throw new System.NotImplementedException();
  }
}
