namespace Autodesk.Revit.DB;

public partial class ParameterFilterElement : Autodesk.Revit.DB.FilterElement
{
	public static Autodesk.Revit.DB.ParameterFilterElement Create(Autodesk.Revit.DB.Document aDocument,System.String name,ICollection<Autodesk.Revit.DB.ElementId> categories,Autodesk.Revit.DB.ElementFilter elementFilter) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ParameterFilterElement Create(Autodesk.Revit.DB.Document aDocument,System.String name,ICollection<Autodesk.Revit.DB.ElementId> categories) => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetCategories() => throw new System.NotImplementedException();
	public virtual void SetCategories(ICollection<Autodesk.Revit.DB.ElementId> categories) => throw new System.NotImplementedException();
	public static System.Boolean ElementFilterIsAcceptableForParameterFilterElement(Autodesk.Revit.DB.Document aDocument,ISet<Autodesk.Revit.DB.ElementId> categories,Autodesk.Revit.DB.ElementFilter elementFilter) => throw new System.NotImplementedException();
	public virtual System.Boolean ElementFilterIsAcceptableForParameterFilterElement(Autodesk.Revit.DB.ElementFilter elementFilter) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementFilter GetElementFilter() => throw new System.NotImplementedException();
	public virtual System.Boolean SetElementFilter(Autodesk.Revit.DB.ElementFilter elementFilter) => throw new System.NotImplementedException();
	public virtual void ClearRules() => throw new System.NotImplementedException();
	public virtual System.Boolean AllRuleParametersApplicable(Autodesk.Revit.DB.ElementFilter elementFilter) => throw new System.NotImplementedException();
	public static System.Boolean AllRuleParametersApplicable(Autodesk.Revit.DB.Document aDocument,ICollection<Autodesk.Revit.DB.ElementId> categories,Autodesk.Revit.DB.ElementFilter elementFilter) => throw new System.NotImplementedException();
	public virtual ISet<Autodesk.Revit.DB.ElementId> GetElementFilterParameters() => throw new System.NotImplementedException();
	public virtual ISet<Autodesk.Revit.DB.ElementId> GetElementFilterParametersForCategory(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
}
