namespace Autodesk.Revit.Creation;

public partial class ItemFactoryBase : Autodesk.Revit.DB.APIObject
{
  public ItemFactoryBase() { }

  public virtual Autodesk.Revit.DB.DetailCurve NewDetailCurve(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Curve geometryCurve
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DetailCurveArray NewDetailCurveArray(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.CurveArray geometryCurveArray
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewDimension(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Line line,
    Autodesk.Revit.DB.ReferenceArray references,
    Autodesk.Revit.DB.DimensionType dimensionType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewDimension(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Line line,
    Autodesk.Revit.DB.ReferenceArray references
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.Line line,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.View specView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.XYZ origin,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.View specView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.Reference reference,
    Autodesk.Revit.DB.Line position,
    Autodesk.Revit.DB.FamilySymbol symbol
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.Reference reference,
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.XYZ referenceDirection,
    Autodesk.Revit.DB.FamilySymbol symbol
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.Face face,
    Autodesk.Revit.DB.Line position,
    Autodesk.Revit.DB.FamilySymbol symbol
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.Face face,
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.XYZ referenceDirection,
    Autodesk.Revit.DB.FamilySymbol symbol
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.Element host,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyInstance NewFamilyInstance(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.FamilySymbol symbol,
    Autodesk.Revit.DB.XYZ referenceDirection,
    Autodesk.Revit.DB.Element host,
    Autodesk.Revit.DB.Structure.StructuralType structuralType
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> NewFamilyInstances2(
    System.Collections.Generic.List<Autodesk.Revit.Creation.FamilyInstanceCreationData> dataList
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Group NewGroup(
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ModelCurve NewModelCurve(
    Autodesk.Revit.DB.Curve geometryCurve,
    Autodesk.Revit.DB.SketchPlane sketchPlane
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ModelCurveArray NewModelCurveArray(
    Autodesk.Revit.DB.CurveArray geometryCurveArray,
    Autodesk.Revit.DB.SketchPlane sketchPlane
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ReferencePlane NewReferencePlane(
    Autodesk.Revit.DB.XYZ bubbleEnd,
    Autodesk.Revit.DB.XYZ freeEnd,
    Autodesk.Revit.DB.XYZ cutVec,
    Autodesk.Revit.DB.View pView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ReferencePlane NewReferencePlane2(
    Autodesk.Revit.DB.XYZ bubbleEnd,
    Autodesk.Revit.DB.XYZ freeEnd,
    Autodesk.Revit.DB.XYZ thirdPnt,
    Autodesk.Revit.DB.View pView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Group PlaceGroup(
    Autodesk.Revit.DB.XYZ location,
    Autodesk.Revit.DB.GroupType groupType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewAlignment(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Reference reference1,
    Autodesk.Revit.DB.Reference reference2
  ) => throw new System.NotImplementedException();
}
