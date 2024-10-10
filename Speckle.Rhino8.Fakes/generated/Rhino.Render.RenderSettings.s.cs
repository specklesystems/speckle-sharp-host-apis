namespace Rhino.Render;

public partial class RenderSettings : Rhino.Runtime.CommonObject
{
  public RenderSettings() { }

  public RenderSettings(Rhino.Render.RenderSettings source) => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderSettings Duplicate() => throw new System.NotImplementedException();

  public virtual System.Boolean RenderEnvironmentOverride(Rhino.Render.RenderSettings.EnvironmentUsage usage) =>
    throw new System.NotImplementedException();

  public virtual void SetRenderEnvironmentOverride(
    Rhino.Render.RenderSettings.EnvironmentUsage usage,
    System.Boolean on
  ) => throw new System.NotImplementedException();

  public virtual System.Guid RenderEnvironmentId(
    Rhino.Render.RenderSettings.EnvironmentUsage usage,
    Rhino.Render.RenderSettings.EnvironmentPurpose purpose
  ) => throw new System.NotImplementedException();

  public virtual void SetRenderEnvironmentId(Rhino.Render.RenderSettings.EnvironmentUsage usage, System.Guid guid) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderEnvironment RenderEnvironment(
    Rhino.Render.RenderSettings.EnvironmentUsage usage,
    Rhino.Render.RenderSettings.EnvironmentPurpose purpose
  ) => throw new System.NotImplementedException();

  public virtual void SetRenderEnvironment(
    Rhino.Render.RenderSettings.EnvironmentUsage usage,
    Rhino.Render.RenderEnvironment env
  ) => throw new System.NotImplementedException();

  public virtual System.Drawing.Color AmbientLight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color BackgroundColorTop
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color BackgroundColorBottom
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseHiddenLights
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DepthCue
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean FlatShade
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean RenderBackfaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean RenderPoints
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean RenderCurves
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean RenderIsoparams
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean RenderMeshEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean RenderAnnotations
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.AntialiasLevel AntialiasLevel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseViewportSize
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ScaleBackgroundToFit
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean TransparentBackground
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.UnitSystem ImageUnitSystem
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ImageDpi
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Size ImageSize
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ShadowmapLevel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.BackgroundStyle BackgroundStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Render.LinearWorkflow LinearWorkflow
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Render.Dithering Dithering
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Render.RenderChannels RenderChannels
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Render.GroundPlane GroundPlane
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Render.SafeFrame SafeFrame
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Render.Skylight Skylight
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Render.Sun Sun
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String NamedView
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Snapshot
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String SpecificViewport
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Render.RenderSettings.RenderingSources RenderSource
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
