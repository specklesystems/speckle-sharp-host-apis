namespace Autodesk.Revit.DB;

public partial class CustomExporter : System.IDisposable
{
	public CustomExporter() {}
	public CustomExporter(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.IExportContext context) => throw new System.NotImplementedException();
	public virtual void Export(System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> viewIds) => throw new System.NotImplementedException();
	public virtual void Export(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public static System.Boolean IsRenderingSupported() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.DisplayStyle Export2DForceDisplayStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean Export2DIncludingAnnotationObjects
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean Export2DGeometricObjectsIncludingPatternLines
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IncludeGeometricObjects
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShouldStopOnError
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
