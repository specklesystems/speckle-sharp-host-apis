namespace Autodesk.Revit.DB;

public partial class IPerformanceAdviserRule
{
	public virtual void InitCheck(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual void FinalizeCheck(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual void ExecuteElementCheck(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual System.Boolean WillCheckElements() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementFilter GetElementFilter(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual System.String GetName() => throw new System.NotImplementedException();
	public virtual System.String GetDescription() => throw new System.NotImplementedException();
}
