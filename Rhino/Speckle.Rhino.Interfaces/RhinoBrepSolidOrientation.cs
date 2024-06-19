namespace Speckle.Rhino7.Interfaces;

public enum RhinoBrepSolidOrientation
{
  /// <summary>Brep is a Solid with inward facing normals.</summary>
  Inward = -1, // 0xFFFFFFFF

  /// <summary>Brep is not a Solid.</summary>
  None = 0,

  /// <summary>Brep is a Solid with outward facing normals.</summary>
  Outward = 1,

  /// <summary>
  /// Breps is a Solid but no orientation could be computed.
  /// </summary>
  Unknown = 2,
}
