namespace Autodesk.Revit.DB;

public partial class BasePoint : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.XYZ get_Position() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_SharedPosition() => throw new System.NotImplementedException();
}
