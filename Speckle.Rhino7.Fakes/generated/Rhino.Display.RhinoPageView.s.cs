namespace Rhino.Display;

public partial class RhinoPageView : Rhino.Display.RhinoView
{
	public RhinoPageView() {}
	public virtual Rhino.Display.RhinoPageView Duplicate(System.Boolean duplicatePageGeometry) => throw new System.NotImplementedException();
	public virtual void SetPageAsActive() => throw new System.NotImplementedException();
	public virtual System.Boolean SetActiveDetail(System.Guid detailId) => throw new System.NotImplementedException();
	public virtual System.Boolean SetActiveDetail(System.String detailName,System.Boolean compareCase) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.DetailViewObject AddDetailView(System.String title,Rhino.Geometry.Point2d corner0,Rhino.Geometry.Point2d corner1,Rhino.Display.DefinedViewportProjection initialProjection) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.DetailViewObject[] GetDetailViews() => throw new System.NotImplementedException();
	public new Rhino.Display.RhinoViewport ActiveViewport
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid ActiveDetailId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.DetailViewObject ActiveDetail
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean PageIsActive
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 PageNumber
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PageWidth
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PageHeight
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String PageName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String PrinterName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String PaperName
	{
		get => throw new System.NotImplementedException();
	}
}
