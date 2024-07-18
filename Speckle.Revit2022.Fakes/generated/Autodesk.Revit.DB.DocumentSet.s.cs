namespace Autodesk.Revit.DB;

public partial class DocumentSet : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerable
{
  public DocumentSet() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DocumentSetIterator ForwardIterator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DocumentSetIterator ReverseIterator() => throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Autodesk.Revit.DB.Document item) => throw new System.NotImplementedException();

  public virtual System.Boolean Insert(Autodesk.Revit.DB.Document item) => throw new System.NotImplementedException();

  public virtual System.Int32 Erase(Autodesk.Revit.DB.Document item) => throw new System.NotImplementedException();

  public virtual System.Boolean IsEmpty
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Size
  {
    get => throw new System.NotImplementedException();
  }
}
