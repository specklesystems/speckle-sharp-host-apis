namespace Autodesk.Revit.DB.Electrical;

public partial class ConduitSizeSettings
  : Autodesk.Revit.DB.Element,
    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<
      System.String,
      Autodesk.Revit.DB.Electrical.ConduitSizes
    >>
{
  public static Autodesk.Revit.DB.Electrical.ConduitSizeSettings GetConduitSizeSettings(
    Autodesk.Revit.DB.Document aDoc
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 GetSizeCount(System.String standardName) => throw new System.NotImplementedException();

  public virtual void AddSize(System.String standardName, Autodesk.Revit.DB.Electrical.ConduitSize sizeInfo) =>
    throw new System.NotImplementedException();

  public virtual void RemoveSize(System.String standardName, System.Double nominalDiameter) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CreateConduitStandardTypeFromExisingStandardType(
    Autodesk.Revit.DB.Document pADoc,
    System.String newStandardName,
    System.String existingStandardName
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean DoesConduitStandardTypeExist(System.String standardName) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean RemoveConduitStandardType(
    Autodesk.Revit.DB.Document pADoc,
    System.String standardName
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.ConduitSizeSettingIterator GetConduitSizeSettingsIterator() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<
    System.String,
    Autodesk.Revit.DB.Electrical.ConduitSizes
  >> GetEnumerator() => throw new System.NotImplementedException();
}
