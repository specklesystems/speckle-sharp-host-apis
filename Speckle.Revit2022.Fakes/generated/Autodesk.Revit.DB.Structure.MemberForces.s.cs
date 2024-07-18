namespace Autodesk.Revit.DB.Structure;

public partial class MemberForces : System.IDisposable
{
  public MemberForces() { }

  public MemberForces(System.Boolean start, Autodesk.Revit.DB.XYZ force, Autodesk.Revit.DB.XYZ moment) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ Moment
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Force
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Start
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
