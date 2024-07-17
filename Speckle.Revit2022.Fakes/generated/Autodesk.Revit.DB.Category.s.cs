namespace Autodesk.Revit.DB;

public partial class Category : Autodesk.Revit.DB.APIObject
{
  public Category() { }

  public virtual System.Nullable<System.Int32> GetLineWeight(Autodesk.Revit.DB.GraphicsStyleType graphicsStyleType) =>
    throw new System.NotImplementedException();

  public virtual void SetLineWeight(System.Int32 lineWeight, Autodesk.Revit.DB.GraphicsStyleType graphicsStyleType) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetLinePatternId(Autodesk.Revit.DB.GraphicsStyleType graphicsStyleType) =>
    throw new System.NotImplementedException();

  public virtual void SetLinePatternId(
    Autodesk.Revit.DB.ElementId linePatternId,
    Autodesk.Revit.DB.GraphicsStyleType graphicsStyleType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.GraphicsStyle GetGraphicsStyle(
    Autodesk.Revit.DB.GraphicsStyleType graphicsStyleType
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Category GetCategory(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId categoryId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Category GetCategory(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.BuiltInCategory categoryId
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsBuiltInCategoryValid(Autodesk.Revit.DB.BuiltInCategory builtInCategory) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ForgeTypeId GetBuiltInCategoryTypeId(Autodesk.Revit.DB.BuiltInCategory categoryId) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.BuiltInCategory GetBuiltInCategory(Autodesk.Revit.DB.ForgeTypeId categoryTypeId) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsBuiltInCategory(Autodesk.Revit.DB.ForgeTypeId categoryTypeId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean get_Visible(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();

  public virtual void set_Visible(Autodesk.Revit.DB.View view, System.Boolean visible) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean get_AllowsVisibilityControl(Autodesk.Revit.DB.View view) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsVisibleInUI
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.CategoryType CategoryType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsTagCategory
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasMaterialQuantities
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean AllowsBoundParameters
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Material Material
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId Id
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Category Parent
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.CategoryNameMap SubCategories
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CanAddSubcategory
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsCuttable
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Color LineColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
  }
}
