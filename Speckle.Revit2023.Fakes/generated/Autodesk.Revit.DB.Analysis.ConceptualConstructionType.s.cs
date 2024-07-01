namespace Autodesk.Revit.DB.Analysis;

public partial class ConceptualConstructionType : Autodesk.Revit.DB.ElementType
{
  public static Autodesk.Revit.DB.ElementId GetWallConstructionType(
    Autodesk.Revit.DB.Document ccda,
    Autodesk.Revit.DB.Analysis.ConceptualConstructionWallType typeEnum
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId GetRoofConstructionType(
    Autodesk.Revit.DB.Document ccda,
    Autodesk.Revit.DB.Analysis.ConceptualConstructionRoofType typeEnum
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId GetFloorOrSlabConstructionType(
    Autodesk.Revit.DB.Document ccda,
    Autodesk.Revit.DB.Analysis.ConceptualConstructionFloorSlabType typeEnum
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId GetWindowOrSkylightConstructionType(
    Autodesk.Revit.DB.Document ccda,
    Autodesk.Revit.DB.Analysis.ConceptualConstructionWindowSkylightType typeEnum
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId GetShadeConstructionType(
    Autodesk.Revit.DB.Document ccda,
    Autodesk.Revit.DB.Analysis.ConceptualConstructionShadeType typeEnum
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId GetOpeningConstructionType(
    Autodesk.Revit.DB.Document ccda,
    Autodesk.Revit.DB.Analysis.ConceptualConstructionOpeningType typeEnum
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetAllConceptualConstructionsForCategory(
    Autodesk.Revit.DB.Document ccda,
    Autodesk.Revit.DB.ElementId massSubCategoryId
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidConceptualConstructionId(
    Autodesk.Revit.DB.Document ccda,
    Autodesk.Revit.DB.ElementId constructionTypeId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidSurfaceSubcategoryForConstruction(
    Autodesk.Revit.DB.ElementId massSurfaceSubcategoryId
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidConceptualConstructionIdForCategory(
    Autodesk.Revit.DB.Document ccda,
    Autodesk.Revit.DB.ElementId constructionTypeId,
    Autodesk.Revit.DB.ElementId massSubcategoryId
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 GetGBSId(Autodesk.Revit.DB.ElementId massSurfaceSubCategoryId) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidSubcategoryForMassSurfaceDatas(Autodesk.Revit.DB.ElementId massSubCategoryId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId MassSurfaceSubCategoryId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId MaterialId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
