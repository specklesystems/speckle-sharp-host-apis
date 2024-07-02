namespace Autodesk.Revit.DB;

public partial class ConnectorSet : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerable
{
  public ConnectorSet() { }

  public virtual Autodesk.Revit.DB.ConnectorSetIterator ForwardIterator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ConnectorSetIterator ReverseIterator() => throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Autodesk.Revit.DB.Connector item) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Insert(Autodesk.Revit.DB.Connector item) => throw new System.NotImplementedException();

  public virtual System.Int32 Erase(Autodesk.Revit.DB.Connector item) => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual System.Boolean IsEmpty
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Size
  {
    get => throw new System.NotImplementedException();
  }
}
