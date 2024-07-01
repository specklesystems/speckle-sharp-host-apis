namespace Autodesk.Revit.DB.Mechanical;

public partial class MEPSpaceConstruction
{
  public MEPSpaceConstruction() { }

  public virtual Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction NewConstruction(System.String pName) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction DuplicateConstruction(
    Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction pCurrentConstruction,
    System.String pName
  ) => throw new System.NotImplementedException();

  public virtual void DeleteConstruction(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction pCurrentConstruction) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet SpaceConstructions
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction CurrentConstruction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
