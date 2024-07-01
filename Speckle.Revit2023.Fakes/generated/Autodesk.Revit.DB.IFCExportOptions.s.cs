namespace Autodesk.Revit.DB;

public partial class IFCExportOptions : System.IDisposable
{
  public IFCExportOptions(Autodesk.Revit.DB.IFCExportOptions from) => throw new System.NotImplementedException();

  public IFCExportOptions() => throw new System.NotImplementedException();

  public virtual void Assign(Autodesk.Revit.DB.IFCExportOptions sourceOptions) =>
    throw new System.NotImplementedException();

  public virtual void AddOption(System.String name, System.String value) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId FilterViewId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SpaceBoundaryLevel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String FamilyMappingFile
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportBaseQuantities
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean WallAndColumnSplitting
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.IFCVersion FileVersion
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
