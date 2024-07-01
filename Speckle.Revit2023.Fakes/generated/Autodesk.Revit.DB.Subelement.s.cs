namespace Autodesk.Revit.DB;

public partial class Subelement : System.IDisposable
{
  public static Autodesk.Revit.DB.Subelement Create(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.Reference reference
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidType(Autodesk.Revit.DB.ElementId typeId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetValidTypes() =>
    throw new System.NotImplementedException();

  public virtual void ChangeTypeId(Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetAllParameters() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ParameterValue GetParameterValue(Autodesk.Revit.DB.ElementId parameterId) =>
    throw new System.NotImplementedException();

  public virtual void SetParameterValue(
    Autodesk.Revit.DB.ElementId parameterId,
    Autodesk.Revit.DB.ParameterValue pValue
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsParameterModifiable(Autodesk.Revit.DB.ElementId parameterId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.GeometryObject GetGeometryObject(Autodesk.Revit.DB.View dbView) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.BoundingBoxXYZ GetBoundingBox(Autodesk.Revit.DB.View dbView) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetReference() => throw new System.NotImplementedException();

  public virtual System.Boolean HasParameter(Autodesk.Revit.DB.ElementId parameterId) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidSubelementReference(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.Reference reference
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanHaveTypeAssigned() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String UniqueId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Element Element
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Document Document
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId TypeId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Category Category
  {
    get => throw new System.NotImplementedException();
  }
}
