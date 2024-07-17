namespace Autodesk.Revit.DB;

public partial class PrintSetting : Autodesk.Revit.DB.Element, Autodesk.Revit.DB.IPrintSetting
{
  public PrintSetting() { }

  public virtual Autodesk.Revit.DB.PrintParameters PrintParameters
  {
    get => throw new System.NotImplementedException();
  }
  public new System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
