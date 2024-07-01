namespace Autodesk.Revit.DB.Analysis;

public partial class HVACLoadSpaceType : Autodesk.Revit.DB.Analysis.HVACLoadType
{
  public static Autodesk.Revit.DB.Analysis.HVACLoadSpaceType Create(
    Autodesk.Revit.DB.Document document,
    System.String name
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsNameUnique(System.String name) => throw new System.NotImplementedException();

  public static System.Boolean IsNameUnique(Autodesk.Revit.DB.Document document, System.String name) =>
    throw new System.NotImplementedException();

  public virtual System.String SpaceTypeName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsPlenum
  {
    get => throw new System.NotImplementedException();
  }
}
