namespace Autodesk.Revit.DB;

public partial class ParameterMap : Autodesk.Revit.DB.APIObject,System.Collections.IEnumerable
{
	public ParameterMap() {}
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ParameterMapIterator ForwardIterator() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ParameterMapIterator ReverseIterator() => throw new System.NotImplementedException();
	public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Parameter get_Item(System.String key) => throw new System.NotImplementedException();
	public virtual void set_Item(System.String key,Autodesk.Revit.DB.Parameter item) => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(System.String key) => throw new System.NotImplementedException();
	public virtual System.Boolean Insert(System.String key,Autodesk.Revit.DB.Parameter item) => throw new System.NotImplementedException();
	public virtual System.Int32 Erase(System.String key) => throw new System.NotImplementedException();
	public virtual System.Boolean IsEmpty
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Size
	{
		get => throw new System.NotImplementedException();
	}
}
