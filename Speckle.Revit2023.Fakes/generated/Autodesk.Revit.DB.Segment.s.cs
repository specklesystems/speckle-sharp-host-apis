namespace Autodesk.Revit.DB;

public partial class Segment : Autodesk.Revit.DB.Element
{
  public Segment() { }

  public virtual void AddSize(Autodesk.Revit.DB.MEPSize size) => throw new System.NotImplementedException();

  public virtual void RemoveSize(System.Double nominalDiameter) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.MEPSize> GetSizes() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 SizeCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId MaterialId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Roughness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Description
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
