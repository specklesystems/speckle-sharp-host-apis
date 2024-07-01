namespace Autodesk.Revit.DB;

public partial class ShapeImporter : System.IDisposable
{
	public ShapeImporter() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.GeometryObject> Convert(Autodesk.Revit.DB.Document document,System.String filename) => throw new System.NotImplementedException();
	public static System.Boolean IsServiceAvailable() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ShapeImporter SetDefaultLengthUnit(Autodesk.Revit.DB.ImportUnit defaultLengthUnit) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ImportUnit DefaultLengthUnit
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ShapeImporterSourceFormat InputFormat
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
