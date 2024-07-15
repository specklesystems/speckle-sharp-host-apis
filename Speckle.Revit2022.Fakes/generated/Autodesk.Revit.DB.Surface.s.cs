namespace Autodesk.Revit.DB;

public partial class Surface : System.IDisposable
{
	public Surface() {}
	public virtual void Project(Autodesk.Revit.DB.XYZ point,out Autodesk.Revit.DB.UV uv,out System.Double distance) => throw new System.NotImplementedException();
	public virtual void ProjectWithGuessPoint(Autodesk.Revit.DB.XYZ point,Autodesk.Revit.DB.UV guessUV,out Autodesk.Revit.DB.UV uv,out System.Double distance) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxUV GetBoundingBoxUV() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean OrientationMatchesParametricOrientation
	{
		get => throw new System.NotImplementedException();
	}
}
