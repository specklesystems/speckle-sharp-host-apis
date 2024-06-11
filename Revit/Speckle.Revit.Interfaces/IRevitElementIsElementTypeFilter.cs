using System;

namespace Speckle.Revit.Interfaces;

public interface IRevitElementIsElementTypeFilter : IRevitElementFilter;

public interface IRevitPointCloudFilter : IRevitElementFilter;

public interface IRevitElementCategoryFilter : IRevitElementFilter, IDisposable;
