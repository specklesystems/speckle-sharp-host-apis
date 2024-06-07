namespace Speckle.Revit.Interfaces;

public interface IRevitElement : IRevitObject
{
  IList<IRevitElementId> GetDependentElements(IRevitElementFilter filter);

  IRevitElementId Id { get; }
  IRevitElementId LevelId { get; }
  IRevitCategory Category { get; }
  IRevitDocument Document { get; }
  IRevitElementId GetTypeId();
  string Name { get; }


  IRevitFamilySymbol? ToFamilySymbol();
}
public interface IRevitElementType
{
  string Name { get; }
  string FamilyName { get; }
  
}
public interface IRevitFamilySymbol : IRevitElementType
{
  
}

public interface IRevitBasePoint : IRevitElement
{
  bool IsShared { get; }
  IRevitXYZ Position { get; }

  IRevitParameter? GetParameter(RevitBuiltInParameter parameter);
}

public interface IRevitParameter
{
  bool IsReadOnly { get; }
  string? AsString();

     int AsInteger();
    double AsDouble();
}
