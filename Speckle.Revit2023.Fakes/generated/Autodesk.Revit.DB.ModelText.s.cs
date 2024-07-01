namespace Autodesk.Revit.DB;

public partial class ModelText : Autodesk.Revit.DB.Element
{
  public virtual Autodesk.Revit.DB.FamilyElementVisibility GetVisibility() =>
    throw new System.NotImplementedException();

  public virtual void SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility visibility) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Category Subcategory
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ModelTextType ModelTextType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.HorizontalAlign HorizontalAlignment
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Depth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public new Autodesk.Revit.DB.Location Location
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Text
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
