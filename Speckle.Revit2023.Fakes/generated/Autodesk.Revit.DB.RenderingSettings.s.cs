namespace Autodesk.Revit.DB;

public partial class RenderingSettings : System.IDisposable
{
  public virtual Autodesk.Revit.DB.BackgroundSettings GetBackgroundSettings() =>
    throw new System.NotImplementedException();

  public virtual void SetBackgroundSettings(Autodesk.Revit.DB.BackgroundSettings background) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.RenderingImageExposureSettings GetRenderingImageExposureSettings() =>
    throw new System.NotImplementedException();

  public virtual void SetRenderingImageExposureSettings(Autodesk.Revit.DB.RenderingImageExposureSettings exposure) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.RenderingQualitySettings GetRenderingQualitySettings() =>
    throw new System.NotImplementedException();

  public virtual void SetRenderingQualitySettings(Autodesk.Revit.DB.RenderingQualitySettings settings) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Outline GetRenderingRegionOutline() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ResolutionValue
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.LightingSource LightingSource
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.PrinterResolution PrinterResolution
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ResolutionTarget ResolutionTarget
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.BackgroundStyle BackgroundStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UsesRegionRendering
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
