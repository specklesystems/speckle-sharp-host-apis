namespace Speckle.Revit.Interfaces;

public interface IRevitUnits: IRevitObject
{
  IRevitFormatOptions GetFormatOptions(IRevitForgeTypeId length);
}

