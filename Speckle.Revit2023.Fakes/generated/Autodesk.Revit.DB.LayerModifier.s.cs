namespace Autodesk.Revit.DB;

public partial class LayerModifier : System.IDisposable
{
  public LayerModifier() { }

  public LayerModifier(Autodesk.Revit.DB.ModifierType modifierType, System.String separator) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ModifierType ModifierType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Separator
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
