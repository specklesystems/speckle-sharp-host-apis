namespace Autodesk.Revit.DB;

public partial class CombinableElement : Autodesk.Revit.DB.Element
{
	public CombinableElement() {}
	public virtual Autodesk.Revit.DB.GeomCombinationSet Combinations
	{
		get => throw new System.NotImplementedException();
	}
}
