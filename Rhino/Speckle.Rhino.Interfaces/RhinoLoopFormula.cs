namespace Speckle.Rhino7.Interfaces;

public enum RhinoLoopFormula
{
  /// <summary>The original Loop formula.</summary>
  Loop,

  /// <summary>Warren's improved formula.</summary>
  Warren,

  /// <summary>
  /// The formula as explained by Weimer, improving over Warren's.
  /// </summary>
  WarrenWeimer,
}
