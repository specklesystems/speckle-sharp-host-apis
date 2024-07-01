namespace Autodesk.Revit.DB;

public partial class OffsetSurface : Autodesk.Revit.DB.Surface
{
  public virtual Autodesk.Revit.DB.Surface GetBasisSurface() => throw new System.NotImplementedException();

  public virtual System.Double GetOffsetDistance() => throw new System.NotImplementedException();

  public virtual System.Boolean IsOrientationSameAsBasisSurface() => throw new System.NotImplementedException();
}
