namespace Autodesk.Revit.DB;

public partial class FamilyParameterSet : Autodesk.Revit.DB.APIObject,System.Collections.IEnumerable
{
	public FamilyParameterSet() {}
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameterSetIterator ForwardIterator() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameterSetIterator ReverseIterator() => throw new System.NotImplementedException();
	public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(Autodesk.Revit.DB.FamilyParameter item) => throw new System.NotImplementedException();
	public virtual System.Boolean Insert(Autodesk.Revit.DB.FamilyParameter item) => throw new System.NotImplementedException();
	public virtual System.Int32 Erase(Autodesk.Revit.DB.FamilyParameter item) => throw new System.NotImplementedException();
	public virtual System.Boolean IsEmpty
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Size
	{
		get => throw new System.NotImplementedException();
	}
}
