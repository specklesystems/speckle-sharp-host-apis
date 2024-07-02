namespace Rhino.Display;

public partial class DisplayPipeline
{
  public DisplayPipeline() { }

  public virtual void DrawActivePoint(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();

  public virtual void DrawPoint(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();

  public virtual void DrawPoint(Rhino.Geometry.Point3d point, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawPoint(
    Rhino.Geometry.Point3d point,
    Rhino.Display.PointStyle style,
    System.Single radius,
    System.Drawing.Color color
  ) => throw new System.NotImplementedException();

  public virtual void DrawPoints(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    Rhino.Display.PointStyle style,
    System.Single radius,
    System.Drawing.Color color
  ) => throw new System.NotImplementedException();

  public virtual void DrawPoint(
    Rhino.Geometry.Point3d point,
    Rhino.Display.PointStyle style,
    System.Drawing.Color strokeColor,
    System.Drawing.Color fillColor,
    System.Single radius,
    System.Single strokeWidth,
    System.Single secondarySize,
    System.Single rotationRadians,
    System.Boolean diameterIsInPixels,
    System.Boolean autoScaleForDpi
  ) => throw new System.NotImplementedException();

  public virtual void DrawPoints(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    Rhino.Display.PointStyle style,
    System.Drawing.Color strokeColor,
    System.Drawing.Color fillColor,
    System.Single radius,
    System.Single strokeWidth,
    System.Single secondarySize,
    System.Single rotationRadians,
    System.Boolean diameterIsInPixels,
    System.Boolean autoScaleForDpi
  ) => throw new System.NotImplementedException();

  public virtual void DrawPoint(
    Rhino.Geometry.Point3d point,
    Rhino.Display.PointStyle style,
    System.Int32 radius,
    System.Drawing.Color color
  ) => throw new System.NotImplementedException();

  public virtual void DrawPoints(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    Rhino.Display.PointStyle style,
    System.Int32 radius,
    System.Drawing.Color color
  ) => throw new System.NotImplementedException();

  public virtual void DrawPointCloud(Rhino.Geometry.PointCloud cloud, System.Single size) =>
    throw new System.NotImplementedException();

  public virtual void DrawPointCloud(Rhino.Geometry.PointCloud cloud, System.Single size, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawPointCloud(Rhino.Geometry.PointCloud cloud, System.Int32 size) =>
    throw new System.NotImplementedException();

  public virtual void DrawPointCloud(Rhino.Geometry.PointCloud cloud, System.Int32 size, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawDirectionArrow(
    Rhino.Geometry.Point3d location,
    Rhino.Geometry.Vector3d direction,
    System.Drawing.Color color
  ) => throw new System.NotImplementedException();

  public virtual void DrawArrow(Rhino.Geometry.Line line, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawArrow(
    Rhino.Geometry.Line line,
    System.Drawing.Color color,
    System.Double screenSize,
    System.Double relativeSize
  ) => throw new System.NotImplementedException();

  public virtual void DrawArrows(Rhino.Geometry.Line[] lines, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawArrows(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Line> lines,
    System.Drawing.Color color
  ) => throw new System.NotImplementedException();

  public virtual void DrawArrowHead(
    Rhino.Geometry.Point3d tip,
    Rhino.Geometry.Vector3d direction,
    System.Drawing.Color color,
    System.Double screenSize,
    System.Double worldSize
  ) => throw new System.NotImplementedException();

  public virtual void DrawLineArrow(
    Rhino.Geometry.Line line,
    System.Drawing.Color color,
    System.Int32 thickness,
    System.Double size
  ) => throw new System.NotImplementedException();

  public virtual void DrawLine(Rhino.Geometry.Line line, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawLine(Rhino.Geometry.Line line, System.Drawing.Color color, System.Int32 thickness) =>
    throw new System.NotImplementedException();

  public virtual void DrawLine(Rhino.Geometry.Point3d from, Rhino.Geometry.Point3d to, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawLine(
    Rhino.Geometry.Point3d from,
    Rhino.Geometry.Point3d to,
    System.Drawing.Color color,
    System.Int32 thickness
  ) => throw new System.NotImplementedException();

  public virtual void DrawLineNoClip(
    Rhino.Geometry.Point3d from,
    Rhino.Geometry.Point3d to,
    System.Drawing.Color color,
    System.Int32 thickness
  ) => throw new System.NotImplementedException();

  public virtual void DrawDottedLine(Rhino.Geometry.Line line, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawPatternedLine(
    Rhino.Geometry.Line line,
    System.Drawing.Color color,
    System.Int32 pattern,
    System.Int32 thickness
  ) => throw new System.NotImplementedException();

  public virtual void DrawDottedLine(
    Rhino.Geometry.Point3d from,
    Rhino.Geometry.Point3d to,
    System.Drawing.Color color
  ) => throw new System.NotImplementedException();

  public virtual void DrawPatternedLine(
    Rhino.Geometry.Point3d from,
    Rhino.Geometry.Point3d to,
    System.Drawing.Color color,
    System.Int32 pattern,
    System.Int32 thickness
  ) => throw new System.NotImplementedException();

  public virtual void DrawDottedPolyline(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    System.Drawing.Color color,
    System.Boolean close
  ) => throw new System.NotImplementedException();

  public virtual void DrawPatternedPolyline(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    System.Drawing.Color color,
    System.Int32 pattern,
    System.Int32 thickness,
    System.Boolean close
  ) => throw new System.NotImplementedException();

  public virtual void DrawLines(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Line> lines,
    System.Drawing.Color color
  ) => throw new System.NotImplementedException();

  public virtual void DrawLines(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Line> lines,
    System.Drawing.Color color,
    System.Int32 thickness
  ) => throw new System.NotImplementedException();

  public virtual void DrawPolyline(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> polyline,
    System.Drawing.Color color
  ) => throw new System.NotImplementedException();

  public virtual void DrawPolyline(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> polyline,
    System.Drawing.Color color,
    System.Int32 thickness
  ) => throw new System.NotImplementedException();

  public virtual void DrawPolygon(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    System.Drawing.Color color,
    System.Boolean filled
  ) => throw new System.NotImplementedException();

  public virtual void DrawBitmap(Rhino.Display.DisplayBitmap bitmap, System.Int32 left, System.Int32 top) =>
    throw new System.NotImplementedException();

  public virtual void DrawDot(
    System.Single screenX,
    System.Single screenY,
    System.String text,
    System.Drawing.Color dotColor,
    System.Drawing.Color textColor
  ) => throw new System.NotImplementedException();

  public virtual void DrawDot(System.Single screenX, System.Single screenY, System.String text) =>
    throw new System.NotImplementedException();

  public virtual void DrawDot(
    Rhino.Geometry.Point3d worldPosition,
    System.String text,
    System.Drawing.Color dotColor,
    System.Drawing.Color textColor
  ) => throw new System.NotImplementedException();

  public virtual void DrawDot(Rhino.Geometry.Point3d worldPosition, System.String text) =>
    throw new System.NotImplementedException();

  public virtual void DrawDot(
    Rhino.Geometry.TextDot dot,
    System.Drawing.Color fillColor,
    System.Drawing.Color textColor,
    System.Drawing.Color borderColor
  ) => throw new System.NotImplementedException();

  public virtual void DrawHatch(
    Rhino.Geometry.Hatch hatch,
    System.Drawing.Color hatchColor,
    System.Drawing.Color boundaryColor
  ) => throw new System.NotImplementedException();

  public virtual void DrawGradientHatch(
    Rhino.Geometry.Hatch hatch,
    System.Drawing.Color color1,
    System.Drawing.Color color2,
    Rhino.Geometry.Point3d point1,
    Rhino.Geometry.Point3d point2,
    System.Boolean linearGradient,
    System.Single boundaryThickness,
    System.Drawing.Color boundaryColor
  ) => throw new System.NotImplementedException();

  public virtual void DrawGradientHatch(
    Rhino.Geometry.Hatch hatch,
    System.Collections.Generic.IEnumerable<Rhino.Display.ColorStop> stops,
    Rhino.Geometry.Point3d point1,
    Rhino.Geometry.Point3d point2,
    System.Boolean linearGradient,
    System.Single repeat,
    System.Single boundaryThickness,
    System.Drawing.Color boundaryColor
  ) => throw new System.NotImplementedException();

  public virtual void DrawGradientMesh(
    Rhino.Geometry.Mesh mesh,
    System.Collections.Generic.IEnumerable<Rhino.Display.ColorStop> stops,
    Rhino.Geometry.Point3d point1,
    Rhino.Geometry.Point3d point2,
    System.Boolean linearGradient,
    System.Single repeat
  ) => throw new System.NotImplementedException();

  public virtual void DrawGradientLines(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Line> lines,
    System.Single strokeWidth,
    System.Collections.Generic.IEnumerable<Rhino.Display.ColorStop> stops,
    Rhino.Geometry.Point3d point1,
    Rhino.Geometry.Point3d point2,
    System.Boolean linearGradient,
    System.Single repeat
  ) => throw new System.NotImplementedException();

  public virtual void DrawBox(Rhino.Geometry.BoundingBox box, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawBox(Rhino.Geometry.BoundingBox box, System.Drawing.Color color, System.Int32 thickness) =>
    throw new System.NotImplementedException();

  public virtual void DrawBox(Rhino.Geometry.Box box, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawBox(Rhino.Geometry.Box box, System.Drawing.Color color, System.Int32 thickness) =>
    throw new System.NotImplementedException();

  public virtual void DrawBoxCorners(Rhino.Geometry.BoundingBox box, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawBoxCorners(Rhino.Geometry.BoundingBox box, System.Drawing.Color color, System.Double size) =>
    throw new System.NotImplementedException();

  public virtual void DrawBoxCorners(
    Rhino.Geometry.BoundingBox box,
    System.Drawing.Color color,
    System.Double size,
    System.Int32 thickness
  ) => throw new System.NotImplementedException();

  public virtual void DrawMarker(
    Rhino.Geometry.Point3d tip,
    Rhino.Geometry.Vector3d direction,
    System.Drawing.Color color
  ) => throw new System.NotImplementedException();

  public virtual void DrawMarker(
    Rhino.Geometry.Point3d tip,
    Rhino.Geometry.Vector3d direction,
    System.Drawing.Color color,
    System.Int32 thickness
  ) => throw new System.NotImplementedException();

  public virtual void DrawMarker(
    Rhino.Geometry.Point3d tip,
    Rhino.Geometry.Vector3d direction,
    System.Drawing.Color color,
    System.Int32 thickness,
    System.Double size
  ) => throw new System.NotImplementedException();

  public virtual void DrawMarker(
    Rhino.Geometry.Point3d tip,
    Rhino.Geometry.Vector3d direction,
    System.Drawing.Color color,
    System.Int32 thickness,
    System.Double size,
    System.Double rotation
  ) => throw new System.NotImplementedException();

  public virtual void DrawConstructionPlane(Rhino.DocObjects.ConstructionPlane constructionPlane) =>
    throw new System.NotImplementedException();

  public virtual void Draw2dText(
    System.String text,
    System.Drawing.Color color,
    Rhino.Geometry.Point2d screenCoordinate,
    System.Boolean middleJustified
  ) => throw new System.NotImplementedException();

  public virtual void Draw2dText(
    System.String text,
    System.Drawing.Color color,
    Rhino.Geometry.Point2d screenCoordinate,
    System.Boolean middleJustified,
    System.Int32 height
  ) => throw new System.NotImplementedException();

  public virtual void Draw2dText(
    System.String text,
    System.Drawing.Color color,
    Rhino.Geometry.Point2d screenCoordinate,
    System.Boolean middleJustified,
    System.Int32 height,
    System.String fontface
  ) => throw new System.NotImplementedException();

  public virtual void Draw2dText(
    System.String text,
    System.Drawing.Color color,
    Rhino.Geometry.Point3d worldCoordinate,
    System.Boolean middleJustified
  ) => throw new System.NotImplementedException();

  public virtual void Draw2dText(
    System.String text,
    System.Drawing.Color color,
    Rhino.Geometry.Point3d worldCoordinate,
    System.Boolean middleJustified,
    System.Int32 height
  ) => throw new System.NotImplementedException();

  public virtual void Draw2dText(
    System.String text,
    System.Drawing.Color color,
    Rhino.Geometry.Point3d worldCoordinate,
    System.Boolean middleJustified,
    System.Int32 height,
    System.String fontface
  ) => throw new System.NotImplementedException();

  public virtual void Draw3dText(
    System.String text,
    System.Drawing.Color color,
    Rhino.Geometry.Plane textPlane,
    System.Double height,
    System.String fontface,
    System.Boolean bold,
    System.Boolean italic,
    Rhino.DocObjects.TextHorizontalAlignment horizontalAlignment,
    Rhino.DocObjects.TextVerticalAlignment verticalAlignment
  ) => throw new System.NotImplementedException();

  public virtual void Draw3dText(
    System.String text,
    System.Drawing.Color color,
    Rhino.Geometry.Plane textPlane,
    System.Double height,
    System.String fontface,
    System.Boolean bold,
    System.Boolean italic
  ) => throw new System.NotImplementedException();

  public virtual void Draw3dText(
    System.String text,
    System.Drawing.Color color,
    Rhino.Geometry.Plane textPlane,
    System.Double height,
    System.String fontface
  ) => throw new System.NotImplementedException();

  public virtual void Draw3dText(Rhino.Display.Text3d text, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void Draw3dText(
    Rhino.Display.Text3d text,
    System.Drawing.Color color,
    Rhino.Geometry.Plane textPlane
  ) => throw new System.NotImplementedException();

  public virtual void Draw3dText(
    Rhino.Display.Text3d text,
    System.Drawing.Color color,
    Rhino.Geometry.Point3d textPlaneOrigin
  ) => throw new System.NotImplementedException();

  public virtual void DrawText(Rhino.Geometry.TextEntity text, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawText(Rhino.Geometry.TextEntity text, System.Drawing.Color color, System.Double scale) =>
    throw new System.NotImplementedException();

  public virtual void DrawText(
    Rhino.Geometry.TextEntity text,
    System.Drawing.Color color,
    Rhino.Geometry.Transform xform
  ) => throw new System.NotImplementedException();

  public virtual System.Drawing.Rectangle Measure2dText(
    System.String text,
    Rhino.Geometry.Point2d definitionPoint,
    System.Boolean middleJustified,
    System.Double rotationRadians,
    System.Int32 height,
    System.String fontFace
  ) => throw new System.NotImplementedException();

  public virtual void DrawObject(Rhino.DocObjects.RhinoObject rhinoObject) =>
    throw new System.NotImplementedException();

  public virtual void DrawObject(Rhino.DocObjects.RhinoObject rhinoObject, Rhino.Geometry.Transform xform) =>
    throw new System.NotImplementedException();

  public virtual void DrawAnnotation(Rhino.Geometry.AnnotationBase annotation, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawAnnotationArrowhead(
    Rhino.Geometry.Arrowhead arrowhead,
    Rhino.Geometry.Transform xform,
    System.Drawing.Color color
  ) => throw new System.NotImplementedException();

  public virtual void DrawArc(Rhino.Geometry.Arc arc, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawArc(Rhino.Geometry.Arc arc, System.Drawing.Color color, System.Int32 thickness) =>
    throw new System.NotImplementedException();

  public virtual void DrawCircle(Rhino.Geometry.Circle circle, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawCircle(Rhino.Geometry.Circle circle, System.Drawing.Color color, System.Int32 thickness) =>
    throw new System.NotImplementedException();

  public virtual void DrawSphere(Rhino.Geometry.Sphere sphere, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawSphere(Rhino.Geometry.Sphere sphere, System.Drawing.Color color, System.Int32 thickness) =>
    throw new System.NotImplementedException();

  public virtual void DrawTorus(Rhino.Geometry.Torus torus, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawTorus(Rhino.Geometry.Torus torus, System.Drawing.Color color, System.Int32 thickness) =>
    throw new System.NotImplementedException();

  public virtual void DrawCylinder(Rhino.Geometry.Cylinder cylinder, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawCylinder(
    Rhino.Geometry.Cylinder cylinder,
    System.Drawing.Color color,
    System.Int32 thickness
  ) => throw new System.NotImplementedException();

  public virtual void DrawCone(Rhino.Geometry.Cone cone, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawCone(Rhino.Geometry.Cone cone, System.Drawing.Color color, System.Int32 thickness) =>
    throw new System.NotImplementedException();

  public virtual void DrawCurve(Rhino.Geometry.Curve curve, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawCurve(Rhino.Geometry.Curve curve, System.Drawing.Color color, System.Int32 thickness) =>
    throw new System.NotImplementedException();

  public virtual void DrawCurvatureGraph(Rhino.Geometry.Curve curve, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawCurvatureGraph(
    Rhino.Geometry.Curve curve,
    System.Drawing.Color color,
    System.Int32 hairScale
  ) => throw new System.NotImplementedException();

  public virtual void DrawCurvatureGraph(
    Rhino.Geometry.Curve curve,
    System.Drawing.Color color,
    System.Int32 hairScale,
    System.Int32 hairDensity,
    System.Int32 sampleDensity
  ) => throw new System.NotImplementedException();

  public virtual void DrawSurface(
    Rhino.Geometry.Surface surface,
    System.Drawing.Color wireColor,
    System.Int32 wireDensity
  ) => throw new System.NotImplementedException();

  public virtual void DrawSprite(
    Rhino.Display.DisplayBitmap bitmap,
    Rhino.Geometry.Point3d worldLocation,
    System.Single size,
    System.Boolean sizeInWorldSpace
  ) => throw new System.NotImplementedException();

  public virtual void DrawSprite(
    Rhino.Display.DisplayBitmap bitmap,
    Rhino.Geometry.Point3d worldLocation,
    System.Single size,
    System.Drawing.Color blendColor,
    System.Boolean sizeInWorldSpace
  ) => throw new System.NotImplementedException();

  public virtual void DrawSprite(
    Rhino.Display.DisplayBitmap bitmap,
    Rhino.Geometry.Point2d screenLocation,
    System.Single size
  ) => throw new System.NotImplementedException();

  public virtual void DrawSprite(
    Rhino.Display.DisplayBitmap bitmap,
    Rhino.Geometry.Point2d screenLocation,
    System.Single size,
    System.Drawing.Color blendColor
  ) => throw new System.NotImplementedException();

  public virtual void DrawSprite(
    Rhino.Display.DisplayBitmap bitmap,
    Rhino.Geometry.Point2d screenLocation,
    System.Single width,
    System.Single height
  ) => throw new System.NotImplementedException();

  public virtual void DrawSprites(
    Rhino.Display.DisplayBitmap bitmap,
    Rhino.Display.DisplayBitmapDrawList items,
    System.Single size,
    System.Boolean sizeInWorldSpace
  ) => throw new System.NotImplementedException();

  public virtual void DrawSprites(
    Rhino.Display.DisplayBitmap bitmap,
    Rhino.Display.DisplayBitmapDrawList items,
    System.Single size,
    Rhino.Geometry.Vector3d translation,
    System.Boolean sizeInWorldSpace
  ) => throw new System.NotImplementedException();

  public virtual void DrawParticles(Rhino.Geometry.ParticleSystem particles) =>
    throw new System.NotImplementedException();

  public virtual void DrawParticles(Rhino.Geometry.ParticleSystem particles, Rhino.Display.DisplayBitmap bitmap) =>
    throw new System.NotImplementedException();

  public virtual void DrawParticles(Rhino.Geometry.ParticleSystem particles, Rhino.Display.DisplayBitmap[] bitmaps) =>
    throw new System.NotImplementedException();

  public virtual void Draw2dRectangle(
    System.Drawing.Rectangle rectangle,
    System.Drawing.Color strokeColor,
    System.Int32 thickness,
    System.Drawing.Color fillColor
  ) => throw new System.NotImplementedException();

  public virtual void DrawRoundedRectangle(
    System.Drawing.PointF center,
    System.Single pixelWidth,
    System.Single pixelHeight,
    System.Single cornerRadius,
    System.Drawing.Color strokeColor,
    System.Single strokeWidth,
    System.Drawing.Color fillColor
  ) => throw new System.NotImplementedException();

  public virtual void Draw2dLine(
    System.Drawing.Point from,
    System.Drawing.Point to,
    System.Drawing.Color color,
    System.Single thickness
  ) => throw new System.NotImplementedException();

  public virtual void Draw2dLine(
    System.Drawing.PointF from,
    System.Drawing.PointF to,
    System.Drawing.Color color,
    System.Single thickness
  ) => throw new System.NotImplementedException();

  public static System.UInt32 AvailableOpenGLVersion(out System.Boolean coreProfile) =>
    throw new System.NotImplementedException();

  public static System.Boolean MakeDefaultOpenGLContextCurrent() => throw new System.NotImplementedException();

  public virtual System.Boolean Open() => throw new System.NotImplementedException();

  public virtual System.Boolean Close() => throw new System.NotImplementedException();

  public virtual Rhino.Display.DisplayPipeline Clone(Rhino.Display.RhinoViewport viewport) =>
    throw new System.NotImplementedException();

  public virtual void PushModelTransform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();

  public virtual void PopModelTransform() => throw new System.NotImplementedException();

  public virtual void EnableDepthTesting(System.Boolean enable) => throw new System.NotImplementedException();

  public virtual void EnableDepthWriting(System.Boolean enable) => throw new System.NotImplementedException();

  public virtual void EnableColorWriting(System.Boolean enable) => throw new System.NotImplementedException();

  public virtual void EnableLighting(System.Boolean enable) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Light[] GetLights() => throw new System.NotImplementedException();

  public virtual void EnableClippingPlanes(System.Boolean enable) => throw new System.NotImplementedException();

  public virtual System.Int32 AddClippingPlane(Rhino.Geometry.Point3d point, Rhino.Geometry.Vector3d normal) =>
    throw new System.NotImplementedException();

  public virtual void RemoveClippingPlane(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void PushDepthTesting(System.Boolean enable) => throw new System.NotImplementedException();

  public virtual void PopDepthTesting() => throw new System.NotImplementedException();

  public virtual void PushDepthWriting(System.Boolean enable) => throw new System.NotImplementedException();

  public virtual void PopDepthWriting() => throw new System.NotImplementedException();

  public virtual void PushClipTesting(System.Boolean enable) => throw new System.NotImplementedException();

  public virtual void PopClipTesting() => throw new System.NotImplementedException();

  public virtual void PushCullFaceMode(Rhino.Display.CullFaceMode mode) => throw new System.NotImplementedException();

  public virtual void PopCullFaceMode() => throw new System.NotImplementedException();

  public static void GetDrawListSerialNumbers(
    out System.UInt32 modelSerialNumber,
    out System.UInt32 pageSerialNumber
  ) => throw new System.NotImplementedException();

  public static System.Boolean CullControlPolygon() => throw new System.NotImplementedException();

  public virtual void Flush() => throw new System.NotImplementedException();

  public virtual System.Boolean IsVisible(Rhino.Geometry.Point3d worldCoordinate) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsVisible(Rhino.DocObjects.RhinoObject rhinoObject) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsVisible(Rhino.Geometry.BoundingBox bbox) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsActive(Rhino.DocObjects.RhinoObject rhinoObject) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean InterruptDrawing() => throw new System.NotImplementedException();

  public virtual System.Single[] GetOpenGLWorldToCamera(System.Boolean includeModelTransform) =>
    throw new System.NotImplementedException();

  public virtual System.Single[] GetOpenGLWorldToClip(System.Boolean includeModelTransform) =>
    throw new System.NotImplementedException();

  public virtual System.Single[] GetOpenGLCameraToClip() => throw new System.NotImplementedException();

  public static System.Drawing.Bitmap DrawToBitmap(
    Rhino.Display.RhinoViewport viewport,
    System.Int32 width,
    System.Int32 height
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean DrawStereoFrameBuffer(
    Rhino.DocObjects.ViewportInfo viewportLeft,
    Rhino.DocObjects.ViewportInfo viewportRight,
    out System.UInt32 handleLeft,
    out System.UInt32 handleRight
  ) => throw new System.NotImplementedException();

  public virtual void DrawMeshWires(Rhino.Geometry.Mesh mesh, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawMeshWires(Rhino.Geometry.Mesh mesh, System.Drawing.Color color, System.Int32 thickness) =>
    throw new System.NotImplementedException();

  public virtual void DrawMeshVertices(Rhino.Geometry.Mesh mesh, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawMeshShaded(Rhino.Geometry.Mesh mesh, Rhino.Display.DisplayMaterial material) =>
    throw new System.NotImplementedException();

  public virtual void DrawMeshShaded(
    Rhino.Geometry.Mesh mesh,
    Rhino.Display.DisplayMaterial material,
    System.Int32[] faceIndices
  ) => throw new System.NotImplementedException();

  public virtual void DrawMeshFalseColors(Rhino.Geometry.Mesh mesh) => throw new System.NotImplementedException();

  public virtual void DrawSubDShaded(Rhino.Geometry.SubD subd, Rhino.Display.DisplayMaterial material) =>
    throw new System.NotImplementedException();

  public virtual void DrawSubDWires(Rhino.Geometry.SubD subd, System.Drawing.Color color, System.Single thickness) =>
    throw new System.NotImplementedException();

  public virtual void DrawBrepShaded(Rhino.Geometry.Brep brep, Rhino.Display.DisplayMaterial material) =>
    throw new System.NotImplementedException();

  public virtual void DrawBrepWires(Rhino.Geometry.Brep brep, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawBrepWires(Rhino.Geometry.Brep brep, System.Drawing.Color color, System.Int32 wireDensity) =>
    throw new System.NotImplementedException();

  public virtual void DrawExtrusionWires(Rhino.Geometry.Extrusion extrusion, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawExtrusionWires(
    Rhino.Geometry.Extrusion extrusion,
    System.Drawing.Color color,
    System.Int32 wireDensity
  ) => throw new System.NotImplementedException();

  public virtual void DrawZebraPreview(Rhino.Geometry.Brep brep, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual void DrawZebraPreview(Rhino.Geometry.Mesh mesh, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual System.Drawing.Size FrameSize
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Drawing.Bitmap FrameBuffer
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 DefaultCurveThickness
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsOpenGL
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsStereoMode
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsPrinting
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsInViewCapture
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsDynamicDisplay
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean SupportsShading
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 StereoProjection
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Transform ModelTransform
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ModelTransformIsIdentity
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 RenderPass
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NestLevel
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.RhinoObject ActiveTopLevelObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.RhinoObject ActiveObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ActiveObjectNestingLevel
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.RhinoObject[] ActiveObjectNestingStack
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsOpen
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean DrawingWires
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean DrawingGrips
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean DrawingSurfaces
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean ShadingRequired
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.RhinoViewport Viewport
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Display.DisplayPipelineAttributes DisplayPipelineAttributes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Single DpiScale
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Display.DepthMode DepthMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.ZBiasMode ZBiasMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
