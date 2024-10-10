namespace Rhino.FileIO;

public partial class FilePdf
{
  public FilePdf() { }

  public static Rhino.FileIO.FilePdf Create() => throw new System.NotImplementedException();

  public virtual System.Int32 AddPage(Rhino.Display.ViewCaptureSettings settings) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddPage(System.Int32 widthInDots, System.Int32 heightInDots, System.Int32 dotsPerInch) =>
    throw new System.NotImplementedException();

  public virtual void DrawText(
    System.Int32 pageNumber,
    System.String text,
    System.Double x,
    System.Double y,
    System.Single heightPoints,
    Rhino.DocObjects.Font onfont,
    System.Drawing.Color fillColor,
    System.Drawing.Color strokeColor,
    System.Single strokeWidth,
    System.Single angleDegrees,
    Rhino.DocObjects.TextHorizontalAlignment horizontalAlignment,
    Rhino.DocObjects.TextVerticalAlignment verticalAlignment
  ) => throw new System.NotImplementedException();

  public virtual void DrawPolyline(
    System.Int32 pageNumber,
    System.Drawing.PointF[] polyline,
    System.Drawing.Color fillColor,
    System.Drawing.Color strokeColor,
    System.Single strokeWidth
  ) => throw new System.NotImplementedException();

  public virtual void DrawLine(
    System.Int32 pageNumber,
    System.Drawing.PointF from,
    System.Drawing.PointF to,
    System.Drawing.Color strokeColor,
    System.Single strokeWidth
  ) => throw new System.NotImplementedException();

  public virtual void DrawBitmap(
    System.Int32 pageNumber,
    System.Drawing.Bitmap bitmap,
    System.Single left,
    System.Single top,
    System.Single width,
    System.Single height,
    System.Single rotationInDegrees
  ) => throw new System.NotImplementedException();

  public virtual void Write(System.String filename) => throw new System.NotImplementedException();

  public virtual void Write(System.IO.Stream stream) => throw new System.NotImplementedException();

  public virtual System.Object PdfDocumentImplementation() => throw new System.NotImplementedException();

  public virtual System.Boolean LayersAsOptionalContentGroups
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
