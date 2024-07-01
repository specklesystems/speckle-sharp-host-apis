namespace Autodesk.Revit.DB;

public partial class ExternallyTaggedBRep : Autodesk.Revit.DB.ExternallyTaggedGeometryObject
{
  public virtual Autodesk.Revit.DB.GeometryObject GetTaggedGeometry(Autodesk.Revit.DB.ExternalGeometryId externalId) =>
    throw new System.NotImplementedException();
}
