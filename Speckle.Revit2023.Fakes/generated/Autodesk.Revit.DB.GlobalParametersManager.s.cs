namespace Autodesk.Revit.DB;

public partial class GlobalParametersManager : System.IDisposable
{
	public static System.Boolean AreGlobalParametersAllowed(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAllGlobalParameters(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ElementId FindByName(Autodesk.Revit.DB.Document document,System.String name) => throw new System.NotImplementedException();
	public static System.Boolean IsValidGlobalParameter(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	public static System.Boolean IsUniqueName(Autodesk.Revit.DB.Document document,System.String name) => throw new System.NotImplementedException();
	public static System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetGlobalParametersOrdered(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public static void SortParameters(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ParametersOrder order) => throw new System.NotImplementedException();
	public static System.Boolean MoveParameterUpOrder(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	public static System.Boolean MoveParameterDownOrder(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
