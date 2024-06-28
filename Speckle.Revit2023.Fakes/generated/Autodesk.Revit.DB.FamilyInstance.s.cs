namespace Autodesk.Revit.DB;

public partial class FamilyInstance : Autodesk.Revit.DB.Instance
{
	public virtual Autodesk.Revit.DB.FamilySymbol get_Symbol() => throw new System.NotImplementedException();
	public virtual void set_Symbol(Autodesk.Revit.DB.FamilySymbol pFamilySymbol) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.MEPModel get_MEPModel() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_StructuralMaterialId() => throw new System.NotImplementedException();
	public virtual void set_StructuralMaterialId(Autodesk.Revit.DB.ElementId value) => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.Element get_Host() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference get_HostFace() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_HandOrientation() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_FacingOrientation() => throw new System.NotImplementedException();
	public virtual void FlipFromToRoom() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Element get_SuperComponent() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.IExtension get_ExtensionUtility() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement GetOriginalGeometry(Autodesk.Revit.DB.Options options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetSpatialElementCalculationPoint() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SweptProfile GetSweptProfile() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyInstanceReferenceType GetReferenceType(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
}
