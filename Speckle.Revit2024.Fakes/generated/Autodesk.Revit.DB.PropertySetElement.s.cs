namespace Autodesk.Revit.DB;

public partial class PropertySetElement : Autodesk.Revit.DB.Element
{
  public PropertySetElement() { }

  public virtual Autodesk.Revit.DB.PropertySetElement Duplicate(
    Autodesk.Revit.DB.Document document,
    System.String name
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.PropertySetElement Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ThermalAsset thermalAsset
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.PropertySetElement Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.StructuralAsset structuralAsset
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.StructuralAsset GetStructuralAsset() => throw new System.NotImplementedException();

  public virtual void SetStructuralAsset(Autodesk.Revit.DB.StructuralAsset structuralAsset) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ThermalAsset GetThermalAsset() => throw new System.NotImplementedException();

  public virtual void SetThermalAsset(Autodesk.Revit.DB.ThermalAsset thermalAsset) =>
    throw new System.NotImplementedException();
}
