namespace Autodesk.Revit.DB;

public partial class Revision : Autodesk.Revit.DB.Element
{
	public Revision() {}
	public static System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetAllRevisionIds(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Revision Create(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public static void ReorderRevisionSequence(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> newSequence) => throw new System.NotImplementedException();
	public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> CombineWithPrevious(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId revisionId) => throw new System.NotImplementedException();
	public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> CombineWithNext(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId revisionId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId RevisionNumberingSequenceId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.RevisionNumberType NumberType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.RevisionVisibility Visibility
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String RevisionDate
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String IssuedBy
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String IssuedTo
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean Issued
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Description
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String RevisionNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 SequenceNumber
	{
		get => throw new System.NotImplementedException();
	}
}
