namespace Autodesk.Revit.DB;

public partial class RevisionNumberingSequence : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.RevisionNumberingSequence CreateNumericSequence(Autodesk.Revit.DB.Document document,System.String name,Autodesk.Revit.DB.NumericRevisionSettings settings) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.RevisionNumberingSequence CreateAlphanumericSequence(Autodesk.Revit.DB.Document document,System.String name,Autodesk.Revit.DB.AlphanumericRevisionSettings settings) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.NumericRevisionSettings GetNumericRevisionSettings() => throw new System.NotImplementedException();
	public virtual void SetNumericRevisionSettings(Autodesk.Revit.DB.NumericRevisionSettings settings) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.AlphanumericRevisionSettings GetAlphanumericRevisionSettings() => throw new System.NotImplementedException();
	public virtual void SetAlphanumericRevisionSettings(Autodesk.Revit.DB.AlphanumericRevisionSettings settings) => throw new System.NotImplementedException();
	public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAllRevisionNumberingSequences(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual System.Boolean HasValidRevisionSettingsForNumberType() => throw new System.NotImplementedException();
	public virtual System.Boolean HasValidNumericRevisionSettings() => throw new System.NotImplementedException();
	public virtual System.Boolean HasValidAlphanumericRevisionSettings() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RevisionNumberType NumberType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String SequenceName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
