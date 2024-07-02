namespace Autodesk.Revit.DB;

public partial class InstanceNode : Autodesk.Revit.DB.GroupNode
{
	public InstanceNode() {}
	public virtual Autodesk.Revit.DB.SymbolGeometryId GetSymbolGeometryId() => throw new System.NotImplementedException();
}
