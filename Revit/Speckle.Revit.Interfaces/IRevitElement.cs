using System;
using System.Collections.Generic;

namespace Speckle.Revit.Interfaces;

public interface IRevitElement : IRevitObject
{
  IList<IRevitElementId> GetDependentElements(IRevitElementFilter filter);

  IRevitElementId Id { get; }
  string UniqueId { get; }
  IRevitElementId LevelId { get; }
  IRevitCategory Category { get; }
  IRevitDocument Document { get; }
  IRevitElementId GetTypeId();
  string Name { get; }
  IRevitBoundingBoxXYZ GetBoundingBox();

  IRevitFamilySymbol? ToFamilySymbol();
  IRevitMaterial? ToMaterial();
  IRevitHostObject? ToHostObject();
  IRevitGroup? ToGroup();
  IRevitGraphicsStyle? ToGraphicsStyle();
  IRevitElementType? ToType();
  IRevitSketch? ToSketch();
  IRevitFloor? ToFloor();
  IRevitModelLine? ToModelLine();
  IRevitLevel? ToLevel();
  IRevitLocation Location { get; }

  IRevitLocationPoint? GetLocationAsLocationPoint();
  IRevitLocationCurve? GetLocationAsLocationCurve();

  IRevitParameterSet Parameters { get; }

  IRevitParameter? GetParameter(RevitBuiltInParameter parameter);

  IRevitGeometryElement GetGeometry(IRevitOptions options);
}

public interface IRevitParameterSet : IEnumerable<IRevitParameter>, IDisposable;

public interface IRevitElementType
{
  string Name { get; }
  string FamilyName { get; }
}

public interface IRevitFamilySymbol : IRevitElementType;

public interface IRevitBasePoint : IRevitElement
{
  bool IsShared { get; }
  IRevitXYZ Position { get; }
}

public interface IRevitParameter
{
  bool IsReadOnly { get; }
  bool HasValue { get; }
  bool IsShared { get; }
  Guid GUID { get; }
  string? AsString();

  int AsInteger();
  double AsDouble();
  IRevitElementId? AsElementId();
  RevitStorageType StorageType { get; }
  IRevitForgeTypeId GetUnitTypeId();
  IRevitDefinition Definition { get; }
}

public interface IRevitDefinition
{
  IRevitInternalDefinition? ToInternal();
  string Name { get; }
  IRevitForgeTypeId GetGroupTypeId();
  IRevitForgeTypeId GetDataType();
}

public interface IRevitInternalDefinition : IRevitDefinition
{
  RevitBuiltInParameter BuiltInParameter { get; }
}

public enum RevitStorageType
{
  None,
  Integer,
  Double,
  String,
  ElementId,
}
