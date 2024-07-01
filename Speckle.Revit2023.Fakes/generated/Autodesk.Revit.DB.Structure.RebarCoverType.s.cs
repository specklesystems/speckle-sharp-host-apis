namespace Autodesk.Revit.DB.Structure;

public partial class RebarCoverType : Autodesk.Revit.DB.ElementType
{
  public static Autodesk.Revit.DB.Structure.RebarCoverType Create(
    Autodesk.Revit.DB.Document doc,
    System.String name,
    System.Double coverDistance
  ) => throw new System.NotImplementedException();

  public virtual System.Double CoverDistance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
