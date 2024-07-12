namespace Autodesk.Revit.Creation;

public partial class FamilyItemFactory : Autodesk.Revit.Creation.ItemFactoryBase
{
  public FamilyItemFactory() { }

  public virtual Autodesk.Revit.DB.Extrusion NewExtrusion(
    System.Boolean isSolid,
    Autodesk.Revit.DB.CurveArrArray profile,
    Autodesk.Revit.DB.SketchPlane sketchPlane,
    System.Double end
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Blend NewBlend(
    System.Boolean isSolid,
    Autodesk.Revit.DB.CurveArray profile1,
    Autodesk.Revit.DB.CurveArray profile2,
    Autodesk.Revit.DB.SketchPlane sketchPlane
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Revolution NewRevolution(
    System.Boolean isSolid,
    Autodesk.Revit.DB.CurveArrArray profile,
    Autodesk.Revit.DB.SketchPlane sketchPlane,
    Autodesk.Revit.DB.Line axis,
    System.Double startAngle,
    System.Double endAngle
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Sweep NewSweep(
    System.Boolean isSolid,
    Autodesk.Revit.DB.ReferenceArray path,
    Autodesk.Revit.DB.SweepProfile profile,
    System.Int32 profileLocationCurveIndex,
    Autodesk.Revit.DB.ProfilePlaneLocation profilePlaneLocation
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Sweep NewSweep(
    System.Boolean isSolid,
    Autodesk.Revit.DB.CurveArray path,
    Autodesk.Revit.DB.SketchPlane pathPlane,
    Autodesk.Revit.DB.SweepProfile profile,
    System.Int32 profileLocationCurveIndex,
    Autodesk.Revit.DB.ProfilePlaneLocation profilePlaneLocation
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SweptBlend NewSweptBlend(
    System.Boolean isSolid,
    Autodesk.Revit.DB.Reference path,
    Autodesk.Revit.DB.SweepProfile bottomProfile,
    Autodesk.Revit.DB.SweepProfile topProfile
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SweptBlend NewSweptBlend(
    System.Boolean isSolid,
    Autodesk.Revit.DB.Curve path,
    Autodesk.Revit.DB.SketchPlane pathPlane,
    Autodesk.Revit.DB.SweepProfile bottomProfile,
    Autodesk.Revit.DB.SweepProfile topProfile
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Form NewLoftForm(
    System.Boolean isSolid,
    Autodesk.Revit.DB.ReferenceArrayArray profiles
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Form NewExtrusionForm(
    System.Boolean isSolid,
    Autodesk.Revit.DB.ReferenceArray profile,
    Autodesk.Revit.DB.XYZ direction
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Form NewSweptBlendForm(
    System.Boolean isSolid,
    Autodesk.Revit.DB.ReferenceArray path,
    Autodesk.Revit.DB.ReferenceArrayArray profiles
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FormArray NewRevolveForms(
    System.Boolean isSolid,
    Autodesk.Revit.DB.ReferenceArray profile,
    Autodesk.Revit.DB.Reference axis,
    System.Double startAngle,
    System.Double endAngle
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Form NewFormByCap(
    System.Boolean isSolid,
    Autodesk.Revit.DB.ReferenceArray profile
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Form NewFormByThickenSingleSurface(
    System.Boolean isSolid,
    Autodesk.Revit.DB.Form singleSurfaceForm,
    Autodesk.Revit.DB.XYZ thickenDir
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewLinearDimension(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Line line,
    Autodesk.Revit.DB.ReferenceArray references,
    Autodesk.Revit.DB.DimensionType dimensionType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewLinearDimension(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Line line,
    Autodesk.Revit.DB.ReferenceArray references
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewAngularDimension(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Arc arc,
    Autodesk.Revit.DB.Reference firstRef,
    Autodesk.Revit.DB.Reference secondRef,
    Autodesk.Revit.DB.DimensionType dimensionType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewAngularDimension(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Arc arc,
    Autodesk.Revit.DB.Reference firstRef,
    Autodesk.Revit.DB.Reference secondRef
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewArcLengthDimension(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Arc arc,
    Autodesk.Revit.DB.Reference arcRef,
    Autodesk.Revit.DB.Reference firstRef,
    Autodesk.Revit.DB.Reference secondRef,
    Autodesk.Revit.DB.DimensionType dimensionType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewArcLengthDimension(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Arc arc,
    Autodesk.Revit.DB.Reference arcRef,
    Autodesk.Revit.DB.Reference firstRef,
    Autodesk.Revit.DB.Reference secondRef
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewRadialDimension(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Reference arcRef,
    Autodesk.Revit.DB.XYZ origin,
    Autodesk.Revit.DB.DimensionType dimensionType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewRadialDimension(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Reference arcRef,
    Autodesk.Revit.DB.XYZ origin
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Dimension NewDiameterDimension(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.Reference arcRef,
    Autodesk.Revit.DB.XYZ origin
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Opening NewOpening(
    Autodesk.Revit.DB.Element host,
    Autodesk.Revit.DB.CurveArray profile
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ModelText NewModelText(
    System.String text,
    Autodesk.Revit.DB.ModelTextType modelTextType,
    Autodesk.Revit.DB.SketchPlane sketchPlane,
    Autodesk.Revit.DB.XYZ position,
    Autodesk.Revit.DB.HorizontalAlign horizontalAlign,
    System.Double depth
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Control NewControl(
    Autodesk.Revit.DB.ControlShape controlShape,
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.XYZ origin
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SymbolicCurve NewSymbolicCurve(
    Autodesk.Revit.DB.Curve curve,
    Autodesk.Revit.DB.SketchPlane sketchPlane
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ReferencePoint NewReferencePoint(Autodesk.Revit.DB.PointElementReference A_0) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ReferencePoint NewReferencePoint(Autodesk.Revit.DB.Transform A_0) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ReferencePoint NewReferencePoint(Autodesk.Revit.DB.XYZ A_0) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveByPoints NewCurveByPoints(Autodesk.Revit.DB.ReferencePointArray points) =>
    throw new System.NotImplementedException();
}
