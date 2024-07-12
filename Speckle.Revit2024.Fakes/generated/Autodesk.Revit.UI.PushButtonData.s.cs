namespace Autodesk.Revit.UI;

public partial class PushButtonData : Autodesk.Revit.UI.ButtonData
{
  public PushButtonData() { }

  public PushButtonData(System.String name, System.String text, System.String assemblyName, System.String className) =>
    throw new System.NotImplementedException();

  public virtual System.String AvailabilityClassName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String AssemblyName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ClassName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
