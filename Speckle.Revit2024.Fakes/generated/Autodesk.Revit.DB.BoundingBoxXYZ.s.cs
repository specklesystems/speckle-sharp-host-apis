namespace Autodesk.Revit.DB;

public partial class BoundingBoxXYZ : Autodesk.Revit.DB.APIObject
{
  public BoundingBoxXYZ() { }

  public virtual Autodesk.Revit.DB.XYZ get_Bounds(System.Int32 bound) => throw new System.NotImplementedException();

  public virtual void set_Bounds(System.Int32 bound, Autodesk.Revit.DB.XYZ __unnamed001) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean get_MinEnabled(System.Int32 dim) => throw new System.NotImplementedException();

  public virtual void set_MinEnabled(System.Int32 dim, System.Boolean enabled) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean get_MaxEnabled(System.Int32 dim) => throw new System.NotImplementedException();

  public virtual void set_MaxEnabled(System.Int32 dim, System.Boolean enabled) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean get_BoundEnabled(System.Int32 bound, System.Int32 dim) =>
    throw new System.NotImplementedException();

  public virtual void set_BoundEnabled(System.Int32 bound, System.Int32 dim, System.Boolean enabled) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSet
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Enabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Max
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Min
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Transform Transform
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
