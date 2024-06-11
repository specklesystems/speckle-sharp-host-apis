namespace Speckle.Revit.Interfaces;

public interface IRevitModelCurve : IRevitCurveElement
{
  IRevitGraphicsStyle Subcategory { get; }
  IRevitElement LineStyle { get; }
}
