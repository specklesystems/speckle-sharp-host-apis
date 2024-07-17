namespace Autodesk.Revit.DB;

public partial class BaseImportOptions : System.IDisposable
{
  public BaseImportOptions() { }

  public virtual void SetLayerSelection(System.Collections.Generic.ICollection<System.String> layerSelection) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<System.String> GetLayerSelection() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ ReferencePoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean AutoCorrectAlmostVHLines
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean VisibleLayersOnly
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double CustomScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean OrientToView
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ThisViewOnly
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ImportPlacement Placement
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ImportColorMode ColorMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ImportUnit Unit
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
