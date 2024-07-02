namespace Rhino.Runtime;

public partial class Interop
{
  public Interop() { }

  public static Rhino.DocObjects.Font FontFromPointer(System.IntPtr ptrManagedFont) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ViewCaptureSettings ViewCaptureFromPointer(System.IntPtr ptrViewCapture) =>
    throw new System.NotImplementedException();

  public static System.IntPtr NativeRhinoDocPointer(Rhino.RhinoDoc doc) => throw new System.NotImplementedException();

  public static System.IntPtr NSFontFromFont(Rhino.DocObjects.Font font) => throw new System.NotImplementedException();

  public static System.IntPtr NSFontFromFont(Rhino.DocObjects.Font font, System.Double pointSize) =>
    throw new System.NotImplementedException();

  public static System.IntPtr NativeGeometryConstPointer(Rhino.Geometry.GeometryBase geometry) =>
    throw new System.NotImplementedException();

  public static System.IntPtr NativeGeometryNonConstPointer(Rhino.Geometry.GeometryBase geometry) =>
    throw new System.NotImplementedException();

  public static System.IntPtr NativeNonConstPointer(Rhino.Display.ViewCaptureSettings settings) =>
    throw new System.NotImplementedException();

  public static System.IntPtr NativeNonConstPointer(Rhino.DocObjects.ViewportInfo viewport) =>
    throw new System.NotImplementedException();

  public static System.IntPtr NativeNonConstPointer(Rhino.Display.RhinoViewport viewport) =>
    throw new System.NotImplementedException();

  public static System.IntPtr NativeNonConstPointer(Rhino.Display.DisplayPipeline pipeline) =>
    throw new System.NotImplementedException();

  public static System.IntPtr RhinoObjectConstPointer(Rhino.DocObjects.RhinoObject rhinoObject) =>
    throw new System.NotImplementedException();

  public static Rhino.DocObjects.RhinoObject RhinoObjectFromPointer(System.IntPtr pRhinoObject) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.GeometryBase CreateFromNativePointer(System.IntPtr pGeometry) =>
    throw new System.NotImplementedException();

  public static System.Boolean TryCopyFromOnArc(System.Object source, out Rhino.Geometry.Arc destination) =>
    throw new System.NotImplementedException();

  public static System.Boolean TryCopyToOnArc(Rhino.Geometry.Arc source, System.Object destination) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Brep FromOnBrep(System.Object source) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Surface FromOnSurface(System.Object source) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh FromOnMesh(System.Object source) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Curve FromOnCurve(System.Object source) => throw new System.NotImplementedException();

  public static System.Object ToOnBrep(Rhino.Geometry.Brep source) => throw new System.NotImplementedException();

  public static System.Object ToOnSurface(Rhino.Geometry.Surface source) => throw new System.NotImplementedException();

  public static System.Object ToOnMesh(Rhino.Geometry.Mesh source) => throw new System.NotImplementedException();

  public static System.Object ToOnCurve(Rhino.Geometry.Curve source) => throw new System.NotImplementedException();

  public static System.Object ToOnXform(Rhino.Geometry.Transform source) => throw new System.NotImplementedException();

  public static System.Object ToIRhinoViewport(Rhino.Display.RhinoViewport source) =>
    throw new System.NotImplementedException();
}
