namespace Autodesk.Revit.DB;

public partial class Transform : Autodesk.Revit.DB.APIObject
{
  public Transform() { }

  public Transform(Autodesk.Revit.DB.Transform source) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ get_Basis(System.Int32 idx) => throw new System.NotImplementedException();

  public virtual void set_Basis(System.Int32 idx, Autodesk.Revit.DB.XYZ __unnamed001) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Transform CreateTranslation(Autodesk.Revit.DB.XYZ vector) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Transform CreateRotation(Autodesk.Revit.DB.XYZ axis, System.Double angle) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Transform CreateRotationAtPoint(
    Autodesk.Revit.DB.XYZ axis,
    System.Double angle,
    Autodesk.Revit.DB.XYZ origin
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Transform CreateReflection(Autodesk.Revit.DB.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ OfPoint(Autodesk.Revit.DB.XYZ point) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ OfVector(Autodesk.Revit.DB.XYZ vec) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform Multiply(Autodesk.Revit.DB.Transform right) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform ScaleBasis(System.Double scale) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform ScaleBasisAndOrigin(System.Double scale) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean AlmostEqual(Autodesk.Revit.DB.Transform right) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform Inverse
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Determinant
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsConformal
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasReflection
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Scale
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsTranslation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsIdentity
  {
    get => throw new System.NotImplementedException();
  }
  public static Autodesk.Revit.DB.Transform Identity
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ Origin
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ BasisZ
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ BasisY
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ BasisX
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
