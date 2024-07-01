namespace Autodesk.Revit.DB;

public partial class ComponentRepeaterSlot : Autodesk.Revit.DB.Element
{
  public virtual System.Boolean IsTypeValidForSlot(Autodesk.Revit.DB.ElementId typeId) =>
    throw new System.NotImplementedException();

  public virtual void MakeEmpty() => throw new System.NotImplementedException();

  public virtual void MakeDefault() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId FamilyType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsDefault
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsEmpty
  {
    get => throw new System.NotImplementedException();
  }
}
