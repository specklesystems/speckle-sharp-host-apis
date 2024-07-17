namespace Autodesk.Revit.DB;

public partial class ColorFillScheme : Autodesk.Revit.DB.Element
{
  public ColorFillScheme() { }

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ColorFillSchemeEntry> GetEntries() =>
    throw new System.NotImplementedException();

  public virtual void UpdateEntry(Autodesk.Revit.DB.ColorFillSchemeEntry entry) =>
    throw new System.NotImplementedException();

  public virtual void SetEntries(System.Collections.Generic.IList<Autodesk.Revit.DB.ColorFillSchemeEntry> entries) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FormatOptions GetFormatOptions() => throw new System.NotImplementedException();

  public virtual void SetFormatOptions(Autodesk.Revit.DB.FormatOptions formatOptions) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetSupportedParameterIds() =>
    throw new System.NotImplementedException();

  public virtual void AddEntry(Autodesk.Revit.DB.ColorFillSchemeEntry entry) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.EntryAndSchemeConsistency IsEntryConsistentWithScheme(
    Autodesk.Revit.DB.ColorFillSchemeEntry entry
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.EntryAndSchemeConsistency AreEntriesConsistentWithScheme(
    System.Collections.Generic.IList<Autodesk.Revit.DB.ColorFillSchemeEntry> entries
  ) => throw new System.NotImplementedException();

  public virtual void SortEntries() => throw new System.NotImplementedException();

  public virtual void RemoveEntry(Autodesk.Revit.DB.ColorFillSchemeEntry entry) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Duplicate(System.String name) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanRemoveEntry(Autodesk.Revit.DB.ColorFillSchemeEntry entry) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanUpdateEntry(Autodesk.Revit.DB.ColorFillSchemeEntry entry) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidSchemeName(System.String name) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidParameterDefinitionId(Autodesk.Revit.DB.ElementId parameterId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanDefineByRange() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId ParameterDefinition
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId AreaSchemeId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsLinkedFilesIncluded
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsByRange
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.StorageType StorageType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId CategoryId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Title
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
