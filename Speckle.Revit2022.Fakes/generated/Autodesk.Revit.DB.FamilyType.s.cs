namespace Autodesk.Revit.DB;

public partial class FamilyType : Autodesk.Revit.DB.APIObject
{
  public FamilyType() { }

  public virtual System.String AsString(Autodesk.Revit.DB.FamilyParameter familyParameter) =>
    throw new System.NotImplementedException();

  public virtual System.Nullable<System.Int32> AsInteger(Autodesk.Revit.DB.FamilyParameter familyParameter) =>
    throw new System.NotImplementedException();

  public virtual System.Nullable<System.Double> AsDouble(Autodesk.Revit.DB.FamilyParameter familyParameter) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId AsElementId(Autodesk.Revit.DB.FamilyParameter familyParameter) =>
    throw new System.NotImplementedException();

  public virtual System.String AsValueString(Autodesk.Revit.DB.FamilyParameter familyParameter) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasValue(Autodesk.Revit.DB.FamilyParameter familyParameter) =>
    throw new System.NotImplementedException();

  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
  }
}
