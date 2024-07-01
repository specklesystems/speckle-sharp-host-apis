namespace Autodesk.Revit.DB;

public partial class CompoundStructureLayer : System.IDisposable
{
  public CompoundStructureLayer(
    System.Double width,
    Autodesk.Revit.DB.MaterialFunctionAssignment function,
    Autodesk.Revit.DB.ElementId materialId
  ) => throw new System.NotImplementedException();

  public CompoundStructureLayer(Autodesk.Revit.DB.CompoundStructureLayer cs) =>
    throw new System.NotImplementedException();

  public CompoundStructureLayer() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean LayerCapFlag
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 LayerId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId DeckProfileId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId MaterialId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.StructDeckEmbeddingType DeckEmbeddingType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.MaterialFunctionAssignment Function
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Width
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
