namespace Autodesk.Revit.DB;

public partial class DirectShapeReferenceOptions : System.IDisposable
{
  public DirectShapeReferenceOptions() { }

  public DirectShapeReferenceOptions(Autodesk.Revit.DB.DirectShapeReferenceOptions other) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidReferenceName(System.String name) => throw new System.NotImplementedException();

  public static System.Boolean IsValidExternalGeometryId(Autodesk.Revit.DB.ExternalGeometryId externalId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DirectShapeReferenceOptions SetExternalGeometryId(
    Autodesk.Revit.DB.ExternalGeometryId externalId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ExternalGeometryId GetExternalGeometryId() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
