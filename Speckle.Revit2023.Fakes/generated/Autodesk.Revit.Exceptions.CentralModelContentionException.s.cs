namespace Autodesk.Revit.Exceptions;

public partial class CentralModelContentionException : Autodesk.Revit.Exceptions.CentralModelException
{
  public CentralModelContentionException() { }

  public virtual System.String CurrentUser
  {
    get => throw new System.NotImplementedException();
  }
}
