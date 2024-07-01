namespace Autodesk.Revit.DB;

public partial class ModelCurve : Autodesk.Revit.DB.CurveElement
{
  public ModelCurve() { }

  public virtual Autodesk.Revit.DB.FamilyElementVisibility GetVisibility() =>
    throw new System.NotImplementedException();

  public virtual void SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility visibility) =>
    throw new System.NotImplementedException();

  public virtual void ChangeToReferenceLine() => throw new System.NotImplementedException();

  public virtual System.Boolean IsReferenceLine
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Structure.TrussCurveType TrussCurveType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.GraphicsStyle Subcategory
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
