namespace Autodesk.Revit.DB;

public partial class FilterableValueProvider : System.IDisposable
{
	public FilterableValueProvider() {}
	public virtual System.String GetStringValue(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual System.Boolean IsStringValueSupported(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual System.Double GetDoubleValue(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual System.Boolean IsDoubleValueSupported(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual System.Int32 GetIntegerValue(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual System.Boolean IsIntegerValueSupported(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetElementIdValue(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual System.Boolean IsElementIdValueSupported(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetAssociatedGlobalParameterValue(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
