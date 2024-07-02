namespace Autodesk.Revit.DB.Structure;

public partial class StructuralConnectionHandlerType : Autodesk.Revit.DB.ElementType
{
  public StructuralConnectionHandlerType() { }

  public virtual System.Boolean IsCustom() => throw new System.NotImplementedException();

  public virtual System.Boolean IsGeneric() => throw new System.NotImplementedException();

  public virtual System.Boolean IsDetailed() => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId CreateDefaultStructuralConnectionHandlerType(
    Autodesk.Revit.DB.Document pADoc
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId GetDefaultConnectionHandlerType(Autodesk.Revit.DB.Document pADoc) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType Create(
    Autodesk.Revit.DB.Document pADoc,
    System.String name,
    System.Guid guid,
    System.String familyName,
    Autodesk.Revit.DB.ElementId categoryId,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.ConnectionInputPointInfo> inputPointsInfo
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType Create(
    Autodesk.Revit.DB.Document pADoc,
    System.String name,
    System.Guid guid,
    System.String familyName,
    Autodesk.Revit.DB.ElementId categoryId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType Create(
    Autodesk.Revit.DB.Document pADoc,
    System.String name,
    System.Guid guid,
    System.String familyName
  ) => throw new System.NotImplementedException();

  public static void AddElementsToCustomConnection(
    Autodesk.Revit.DB.Structure.StructuralConnectionHandler structuralConnectionHandler,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> references
  ) => throw new System.NotImplementedException();

  public static void RemoveMainSubelementsFromCustomConnection(
    Autodesk.Revit.DB.Structure.StructuralConnectionHandler structuralConnectionHandler,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Subelement> subelements
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsTypeNameValidForCustomConnection(
    Autodesk.Revit.DB.Document document,
    System.String typeName
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId FindGenericConnectionType(Autodesk.Revit.DB.Document doc) =>
    throw new System.NotImplementedException();

  public virtual System.Guid ConnectionGuid
  {
    get => throw new System.NotImplementedException();
  }
}
