﻿using System.Diagnostics.CodeAnalysis;
using Autodesk.Revit.DB;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;
#pragma warning disable CA1010
#pragma warning disable CA1710

namespace Speckle.Revit.Api;

[Proxy(
  typeof(Document),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  ["PlanTopology", "PlanTopologies", "TypeOfStorage", "Equals"]
)]
[SuppressMessage("Maintainability", "CA1506:Avoid excessive class coupling")]
public partial interface IRevitDocumentProxy : IRevitDocument;

[Proxy(
  typeof(ForgeTypeId),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  ["Equals"]
)]
public partial interface IRevitForgeTypeIdProxy : IRevitForgeTypeId;

[Proxy(
  typeof(Element),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  ["Parameter", "BoundingBox", "Geometry"]
)]
public partial interface IRevitElementProxy : IRevitElement;

[Proxy(
  typeof(Category),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  ["AllowsVisibilityControl", "Visible"]
)]
public partial interface IRevitCategoryProxy : IRevitCategory;

[Proxy(
  typeof(ElementId),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  ["Equals"]
)]
public partial interface IRevitElementIdProxy : IRevitElementId;

[Proxy(typeof(CurtainGrid), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitCurtainGridProxy : IRevitCurtainGrid;

[Proxy(typeof(Wall), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitWallProxy : IRevitWall;

[Proxy(typeof(HostObject), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitHostObjectProxy : IRevitHostObject;
