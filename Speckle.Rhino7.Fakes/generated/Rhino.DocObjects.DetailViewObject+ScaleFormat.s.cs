namespace Rhino.DocObjects;

public partial class DetailViewObject
{
  public enum ScaleFormat
  {
    None,
    PageLengthToOne,
    OneToModelLength,
    OneInchToModelLengthFeet,
    ModelLengthInchToOneFoot,
    ModelLengthInchToOneFootInch,
  }
}
