namespace Autodesk.Revit.UI;

public partial class EditorInteraction
{
  public EditorInteraction() { }

  public EditorInteraction(Autodesk.Revit.UI.EditorInteractionType interactionType) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.UI.EditorInteractionType InteractionType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
