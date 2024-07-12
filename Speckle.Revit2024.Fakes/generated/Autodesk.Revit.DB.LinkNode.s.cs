namespace Autodesk.Revit.DB;

public partial class LinkNode : Autodesk.Revit.DB.GroupNode
{
  public LinkNode() { }

  public virtual Autodesk.Revit.DB.Document GetDocument() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId SymbolId
  {
    get => throw new System.NotImplementedException();
  }
}
