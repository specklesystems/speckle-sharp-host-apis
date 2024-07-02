namespace Autodesk.Revit.DB;

public partial class ExternallyTaggedNonBRep : Autodesk.Revit.DB.ExternallyTaggedGeometryObject
{
  public ExternallyTaggedNonBRep() { }

  public ExternallyTaggedNonBRep(
    Autodesk.Revit.DB.ExternalGeometryId externalId,
    Autodesk.Revit.DB.GeometryObject geometry
  ) => throw new System.NotImplementedException();
}
