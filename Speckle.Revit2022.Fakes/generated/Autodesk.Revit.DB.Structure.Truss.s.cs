namespace Autodesk.Revit.DB.Structure;

public partial class Truss : Autodesk.Revit.DB.Element
{
	public Truss() {}
	public virtual void AttachChord(Autodesk.Revit.DB.Element attachToElement,Autodesk.Revit.DB.Structure.TrussChordLocation location,System.Boolean forceRemoveSketch) => throw new System.NotImplementedException();
	public virtual void DetachChord(Autodesk.Revit.DB.Structure.TrussChordLocation location) => throw new System.NotImplementedException();
	public virtual void SetProfile(Autodesk.Revit.DB.CurveArray topChords,Autodesk.Revit.DB.CurveArray bottomChords) => throw new System.NotImplementedException();
	public virtual void RemoveProfile() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.TrussMemberInfo GetTrussMemberInfo(Autodesk.Revit.DB.ElementId elemId) => throw new System.NotImplementedException();
	public virtual void TogglePinMember(Autodesk.Revit.DB.ElementId elemId) => throw new System.NotImplementedException();
	public static void DropTruss(Autodesk.Revit.DB.Structure.Truss truss) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.Truss Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId trussTypeId,Autodesk.Revit.DB.ElementId sketchPlaneId,Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.TrussType TrussType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.CurveArray Curves
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> Members
	{
		get => throw new System.NotImplementedException();
	}
}
