namespace Autodesk.Revit.DB;

public partial class AssemblyMemberDifferentCategory : Autodesk.Revit.DB.AssemblyMemberDifference
{
  public AssemblyMemberDifferentCategory() { }

  public virtual Autodesk.Revit.DB.ElementId CategoryId2
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId CategoryId1
  {
    get => throw new System.NotImplementedException();
  }
}
