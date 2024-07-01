namespace Autodesk.Revit.DB;

public partial class RevitLinkOperations : Autodesk.Revit.DB.LinkOperations
{
  public virtual void SetGetLocalPathForOpenCallback(
    Autodesk.Revit.DB.IGetLocalPathForOpenCallback makeLocalCopyForOpen
  ) => throw new System.NotImplementedException();
}
