namespace Autodesk.Revit.DB;

public partial class GeometryCreationUtilities
{
  public static Autodesk.Revit.DB.Solid CreateExtrusionGeometry(
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profileLoops,
    Autodesk.Revit.DB.XYZ extrusionDir,
    System.Double extrusionDist,
    Autodesk.Revit.DB.SolidOptions solidOptions
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateExtrusionGeometry(
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profileLoops,
    Autodesk.Revit.DB.XYZ extrusionDir,
    System.Double extrusionDist
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateRevolvedGeometry(
    Autodesk.Revit.DB.Frame coordinateFrame,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profileLoops,
    System.Double startAngle,
    System.Double endAngle,
    Autodesk.Revit.DB.SolidOptions solidOptions
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateRevolvedGeometry(
    Autodesk.Revit.DB.Frame coordinateFrame,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profileLoops,
    System.Double startAngle,
    System.Double endAngle
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateSweptGeometry(
    Autodesk.Revit.DB.CurveLoop sweepPath,
    System.Int32 pathAttachmentCrvIdx,
    System.Double pathAttachmentParam,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profileLoops,
    Autodesk.Revit.DB.SolidOptions solidOptions
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateSweptGeometry(
    Autodesk.Revit.DB.CurveLoop sweepPath,
    System.Int32 pathAttachmentCrvIdx,
    System.Double pathAttachmentParam,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profileLoops
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateSweptBlendGeometry(
    Autodesk.Revit.DB.Curve pathCurve,
    System.Collections.Generic.IList<System.Double> pathParams,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profileLoops,
    System.Collections.Generic.IList<System.Collections.Generic.ICollection<Autodesk.Revit.DB.VertexPair>> vertexPairs,
    Autodesk.Revit.DB.SolidOptions solidOptions
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateSweptBlendGeometry(
    Autodesk.Revit.DB.Curve pathCurve,
    System.Collections.Generic.IList<System.Double> pathParams,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profileLoops,
    System.Collections.Generic.IList<System.Collections.Generic.ICollection<Autodesk.Revit.DB.VertexPair>> vertexPairs
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateBlendGeometry(
    Autodesk.Revit.DB.CurveLoop firstLoop,
    Autodesk.Revit.DB.CurveLoop secondLoop,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.VertexPair> vertexPairs,
    Autodesk.Revit.DB.SolidOptions solidOptions
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateBlendGeometry(
    Autodesk.Revit.DB.CurveLoop firstLoop,
    Autodesk.Revit.DB.CurveLoop secondLoop,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.VertexPair> vertexPairs
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateLoftGeometry(
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profileLoops,
    Autodesk.Revit.DB.SolidOptions solidOptions
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateFixedReferenceSweptGeometry(
    Autodesk.Revit.DB.CurveLoop sweepPath,
    System.Int32 pathAttachmentCrvIdx,
    System.Double pathAttachmentParam,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profileLoops,
    Autodesk.Revit.DB.XYZ fixedReferenceDirection,
    Autodesk.Revit.DB.SolidOptions solidOptions
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Solid CreateFixedReferenceSweptGeometry(
    Autodesk.Revit.DB.CurveLoop sweepPath,
    System.Int32 pathAttachmentCrvIdx,
    System.Double pathAttachmentParam,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profileLoops,
    Autodesk.Revit.DB.XYZ fixedReferenceDirection
  ) => throw new System.NotImplementedException();
}
