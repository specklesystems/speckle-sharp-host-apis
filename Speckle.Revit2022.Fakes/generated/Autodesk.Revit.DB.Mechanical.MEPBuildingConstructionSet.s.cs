namespace Autodesk.Revit.DB.Mechanical;

public partial class MEPBuildingConstructionSet : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerable
{
  public MEPBuildingConstructionSet() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator ForwardIterator() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator ReverseIterator() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction item) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Insert(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction item) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Erase(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction item) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsEmpty
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Size
  {
    get => throw new System.NotImplementedException();
  }
}
