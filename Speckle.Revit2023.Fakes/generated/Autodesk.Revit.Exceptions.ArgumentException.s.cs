namespace Autodesk.Revit.Exceptions;

public partial class ArgumentException : Autodesk.Revit.Exceptions.ApplicationException
{
  public virtual System.String ParamName
  {
    get => throw new System.NotImplementedException();
  }
  public override System.String Message
  {
    get => throw new System.NotImplementedException();
  }
}
