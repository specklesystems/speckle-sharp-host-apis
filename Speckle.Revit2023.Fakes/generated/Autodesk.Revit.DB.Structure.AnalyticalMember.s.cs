namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalMember : Autodesk.Revit.DB.Structure.AnalyticalElement
{
	public static Autodesk.Revit.DB.Structure.AnalyticalMember Create(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual void SetCurve(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidSectionTypeId(Autodesk.Revit.DB.ElementId familySymbolId) => throw new System.NotImplementedException();
	public static System.Boolean IsValidCurve(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.ReleaseType GetReleaseType(System.Boolean start) => throw new System.NotImplementedException();
	public virtual void SetReleaseType(System.Boolean start,Autodesk.Revit.DB.Structure.ReleaseType releaseType) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.ReleaseConditions> GetReleaseConditions() => throw new System.NotImplementedException();
	public virtual void SetReleaseConditions(Autodesk.Revit.DB.Structure.ReleaseConditions releaseConditions) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.MemberForces> GetMemberForces() => throw new System.NotImplementedException();
	public virtual void SetMemberForces(Autodesk.Revit.DB.Structure.MemberForces memberForces) => throw new System.NotImplementedException();
	public virtual void SetMemberForces(System.Boolean start,Autodesk.Revit.DB.XYZ force,Autodesk.Revit.DB.XYZ moment) => throw new System.NotImplementedException();
	public virtual void FlipCurve() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId SectionTypeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double CrossSectionRotation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
