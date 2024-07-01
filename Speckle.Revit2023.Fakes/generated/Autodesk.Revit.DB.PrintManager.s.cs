namespace Autodesk.Revit.DB;

public partial class PrintManager : Autodesk.Revit.DB.APIObject
{
  public virtual void SelectNewPrintDriver(System.String strPrinterName) => throw new System.NotImplementedException();

  public virtual System.Boolean SubmitPrint(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();

  public virtual System.Boolean SubmitPrint() => throw new System.NotImplementedException();

  public virtual void Apply() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PaperSourceSet PaperSources
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.PaperSizeSet PaperSizes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.VirtualPrinterType IsVirtual
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Collate
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean PrintOrderReverse
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 CopyNumber
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.PrintRange PrintRange
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String PrintToFileName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean CombinedFile
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean PrintToFile
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ViewSheetSetting ViewSheetSetting
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.PrintSetup PrintSetup
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String PrinterName
  {
    get => throw new System.NotImplementedException();
  }
}
