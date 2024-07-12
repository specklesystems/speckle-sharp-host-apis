namespace Autodesk.Revit.DB;

public partial class EdgeEndPoint : System.IDisposable
{
  public EdgeEndPoint() { }

  public EdgeEndPoint(Autodesk.Revit.DB.Edge edge, System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Autodesk.Revit.DB.EdgeEndPoint other) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ Evaluate() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Index
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Edge Edge
  {
    get => throw new System.NotImplementedException();
  }
}
