namespace Autodesk.Revit.DB;

public partial class NumberingSchema : Autodesk.Revit.DB.Element
{
  public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetSchemasInDocument(
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.NumberingSchema GetNumberingSchema(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.NumberingSchemaType schemaType
  ) => throw new System.NotImplementedException();

  public static System.Int32 GetMinimumNumberOfDigits(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static void SetMinimumNumberOfDigits(Autodesk.Revit.DB.Document document, System.Int32 value) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.String> GetNumberingSequences() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.IntegerRange> GetNumbers(System.String partition) =>
    throw new System.NotImplementedException();

  public virtual void RemoveGaps(System.String partition) => throw new System.NotImplementedException();

  public virtual void ShiftNumbers(System.String partition, System.Int32 firstNumber) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> ChangeNumber(
    System.String partition,
    System.Int32 fromNumber,
    System.Int32 toNumber
  ) => throw new System.NotImplementedException();

  public virtual void MoveSequence(System.String fromPartition, System.String newPartition) =>
    throw new System.NotImplementedException();

  public virtual void AppendSequence(System.String fromPartition, System.String toPartition) =>
    throw new System.NotImplementedException();

  public virtual void MergeSequences(
    System.Collections.Generic.IList<System.String> sourcePartitions,
    System.String newPartition
  ) => throw new System.NotImplementedException();

  public virtual void AssignElementsToSequence(
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> elementIds,
    System.String partitionName
  ) => throw new System.NotImplementedException();

  public static System.Int32 MaximumStartingNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.NumberingSchemaType SchemaType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId NumberingParameterId
  {
    get => throw new System.NotImplementedException();
  }
}
