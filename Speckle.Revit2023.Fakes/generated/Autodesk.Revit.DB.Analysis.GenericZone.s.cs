namespace Autodesk.Revit.DB.Analysis;

public partial class GenericZone : Autodesk.Revit.DB.Element
{
	public GenericZone() {}
	public static Autodesk.Revit.DB.Analysis.GenericZone Create(Autodesk.Revit.DB.Document doc,System.String name,Autodesk.Revit.DB.Analysis.GenericZoneDomainData domainData,Autodesk.Revit.DB.ElementId levelId,System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> curveLoops) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Analysis.GenericZoneDomainData GetDomainData() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> GetBoundaries() => throw new System.NotImplementedException();
	public virtual System.Double LevelOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
