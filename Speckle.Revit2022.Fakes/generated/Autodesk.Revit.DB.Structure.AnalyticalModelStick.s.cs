namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalModelStick : Autodesk.Revit.DB.Structure.AnalyticalModel
{
	public AnalyticalModelStick() {}
	public virtual Autodesk.Revit.DB.Transform GetLocalCoordinateSystem(System.Double parameter) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetLocalCoordinateSystem(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.StickElementProjectionY GetProjectionY(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.StickElementProjectionZ GetProjectionZ(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetProjectionPlaneY(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetProjectionPlaneZ(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod GetAlignmentMethod(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector) => throw new System.NotImplementedException();
	public virtual void SetAlignmentMethod(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector,Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod method) => throw new System.NotImplementedException();
	public virtual void SetProjection(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector,Autodesk.Revit.DB.ElementId planeIdY,Autodesk.Revit.DB.ElementId planeIdZ) => throw new System.NotImplementedException();
	public virtual void SetProjection(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector,Autodesk.Revit.DB.Structure.StickElementProjectionY projectionY,Autodesk.Revit.DB.ElementId planeIdZ) => throw new System.NotImplementedException();
	public virtual void SetProjection(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector,Autodesk.Revit.DB.ElementId planeIdY,Autodesk.Revit.DB.Structure.StickElementProjectionZ projectionZ) => throw new System.NotImplementedException();
	public virtual void SetProjection(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector,Autodesk.Revit.DB.Structure.StickElementProjectionY projectionY,Autodesk.Revit.DB.Structure.StickElementProjectionZ projectionZ) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.ReleaseType GetReleaseType(System.Boolean start) => throw new System.NotImplementedException();
	public virtual void SetReleaseType(System.Boolean start,Autodesk.Revit.DB.Structure.ReleaseType releaseType) => throw new System.NotImplementedException();
	public virtual void GetReleases(System.Boolean start,out System.Boolean fx,out System.Boolean fy,out System.Boolean fz,out System.Boolean mx,out System.Boolean my,out System.Boolean mz) => throw new System.NotImplementedException();
	public virtual void SetReleases(System.Boolean start,System.Boolean fx,System.Boolean fy,System.Boolean fz,System.Boolean mx,System.Boolean my,System.Boolean mz) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.MemberForces> GetMemberForces() => throw new System.NotImplementedException();
	public virtual void SetMemberForces(Autodesk.Revit.DB.Structure.MemberForces memberForces) => throw new System.NotImplementedException();
	public virtual void SetMemberForces(System.Boolean start,Autodesk.Revit.DB.XYZ force,Autodesk.Revit.DB.XYZ moment) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveMemberForces(System.Boolean start) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveAllMemberForces() => throw new System.NotImplementedException();
}
