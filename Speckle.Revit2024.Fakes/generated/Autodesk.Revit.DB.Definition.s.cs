namespace Autodesk.Revit.DB;

public partial class Definition
{
	public Definition() {}
	public virtual Autodesk.Revit.DB.ForgeTypeId GetGroupTypeId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ForgeTypeId GetDataType() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BuiltInParameterGroup ParameterGroup
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Name
	{
		get => throw new System.NotImplementedException();
	}
}
