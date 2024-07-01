namespace Autodesk.Revit.DB;

public partial class ReferencePlane : Autodesk.Revit.DB.DatumPlane
{
  public ReferencePlane() { }

  public virtual Autodesk.Revit.DB.Plane GetPlane() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetReference() => throw new System.NotImplementedException();

  public virtual void Flip() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ Direction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Normal
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ FreeEnd
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ BubbleEnd
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public new System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
