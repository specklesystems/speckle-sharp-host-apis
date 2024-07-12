namespace Autodesk.Revit.DB;

public partial class BRepBuilderPersistentIds : System.IDisposable
{
  public BRepBuilderPersistentIds() { }

  public BRepBuilderPersistentIds(Autodesk.Revit.DB.BRepBuilder bRepBuilder) =>
    throw new System.NotImplementedException();

  public virtual void AddSubTag(
    Autodesk.Revit.DB.ExternalGeometryId externalGeometryId,
    Autodesk.Revit.DB.BRepBuilderGeometryId brepBuilderGeometryId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidExternalGeometryIdForNewCorrespondence(
    Autodesk.Revit.DB.ExternalGeometryId externalGeometryId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidBRepBuilderGeometryIdForNewCorrespondence(
    Autodesk.Revit.DB.BRepBuilderGeometryId brepBuilderGeometryId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsAssociatedBRepBuilderValid() => throw new System.NotImplementedException();

  public virtual System.Boolean IsBRepBuilderGeometryIdFaceOrEdge(
    Autodesk.Revit.DB.BRepBuilderGeometryId brepBuilderGeometryId
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
