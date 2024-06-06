using System.Diagnostics.CodeAnalysis;

namespace Speckle.Revit.Interfaces;

[SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix")]
public interface IRevitModelCurveArray : IReadOnlyList<IRevitModelCurve>;
