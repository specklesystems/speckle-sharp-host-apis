namespace Autodesk.Revit.DB.Structure;

public partial class StructuralConnectionType : Autodesk.Revit.DB.ElementType
{
	public StructuralConnectionType() {}
	public static Autodesk.Revit.DB.Structure.StructuralConnectionType Create(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo applyTo,System.String name,Autodesk.Revit.DB.ElementId familySymbolId) => throw new System.NotImplementedException();
	public static void GetAllStructuralConnectionTypeIds(Autodesk.Revit.DB.Document cda,out System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> ids) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetFamilySymbolId() => throw new System.NotImplementedException();
	public virtual void SetFamilySymbolId(Autodesk.Revit.DB.ElementId familySymbolId) => throw new System.NotImplementedException();
	public static System.Boolean ValidFamilySymbolId(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo applyTo,Autodesk.Revit.DB.ElementId familySymbolId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo ApplyTo
	{
		get => throw new System.NotImplementedException();
	}
}
