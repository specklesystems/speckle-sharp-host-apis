namespace Autodesk.Revit.DB;

public partial class CADLinkType : Autodesk.Revit.DB.ElementType
{
  public virtual Autodesk.Revit.DB.LinkLoadResult Reload(Autodesk.Revit.DB.CADLinkOptions options) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.LinkLoadResult Reload() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.LinkLoadResult LoadFrom(
    Autodesk.Revit.DB.ExternalResourceReference resourceReference
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.LinkLoadResult LoadFrom(System.String path) =>
    throw new System.NotImplementedException();
}
