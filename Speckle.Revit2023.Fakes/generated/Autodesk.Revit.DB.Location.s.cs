namespace Autodesk.Revit.DB;

public partial class Location : Autodesk.Revit.DB.APIObject
{
	public Location() {}
	public virtual System.Boolean Move(Autodesk.Revit.DB.XYZ translation) => throw new System.NotImplementedException();
	public virtual System.Boolean Rotate(Autodesk.Revit.DB.Line axis,System.Double angle) => throw new System.NotImplementedException();
}
