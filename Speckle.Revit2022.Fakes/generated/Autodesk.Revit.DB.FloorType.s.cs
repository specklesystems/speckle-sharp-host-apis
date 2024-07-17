namespace Autodesk.Revit.DB;

public partial class FloorType : Autodesk.Revit.DB.HostObjAttributes
{
  public FloorType() { }

  public virtual Autodesk.Revit.DB.ThermalProperties ThermalProperties
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId StructuralMaterialId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsFoundationSlab
  {
    get => throw new System.NotImplementedException();
  }
}
