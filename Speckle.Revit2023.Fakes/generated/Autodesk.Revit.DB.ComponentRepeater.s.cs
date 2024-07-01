namespace Autodesk.Revit.DB;

public partial class ComponentRepeater
  : Autodesk.Revit.DB.Element,
    System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.ComponentRepeaterSlot>
{
  public virtual System.Boolean IsTypeValidForRepeater(Autodesk.Revit.DB.ElementId typeId) =>
    throw new System.NotImplementedException();

  public static System.Boolean CanElementBeRepeated(
    Autodesk.Revit.DB.Document ADoc,
    Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.ComponentRepeater> RepeatElements(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> RemoveRepeaters(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> elementIds
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.ComponentRepeaterSlot> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 DimensionCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId DefaultFamilyType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
