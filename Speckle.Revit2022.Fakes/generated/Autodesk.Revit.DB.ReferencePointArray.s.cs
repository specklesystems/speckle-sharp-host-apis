namespace Autodesk.Revit.DB;

public partial class ReferencePointArray : Autodesk.Revit.DB.APIObject,System.Collections.IEnumerable
{
	public ReferencePointArray() {}
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ReferencePointArrayIterator ForwardIterator() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ReferencePointArrayIterator ReverseIterator() => throw new System.NotImplementedException();
	public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ReferencePoint get_Item(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void set_Item(System.Int32 index,Autodesk.Revit.DB.ReferencePoint item) => throw new System.NotImplementedException();
	public virtual void Append(Autodesk.Revit.DB.ReferencePoint item) => throw new System.NotImplementedException();
	public virtual void Insert(Autodesk.Revit.DB.ReferencePoint item,System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Boolean IsEmpty
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Size
	{
		get => throw new System.NotImplementedException();
	}
}
