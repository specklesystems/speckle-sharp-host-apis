using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Revit.DB.Plumbing
{
  public partial class FluidTemperatureSetIterator
  {
    object IEnumerator.Current => throw new System.NotImplementedException();
  }

  public partial class FluidType
  {
    IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB.Electrical
{
  public partial class CableTraySizeIterator
  {
    object IEnumerator.Current => throw new System.NotImplementedException();
  }

  public partial class CableTraySizes
  {
    IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
  }

  public partial class ConduitSizeIterator
  {
    object IEnumerator.Current => throw new System.NotImplementedException();
  }

  public partial class ConduitSizes
  {
    IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
  }

  public partial class ConduitSizeSettingIterator
  {
    object IEnumerator.Current => throw new System.NotImplementedException();
  }

  public partial class ConduitSizeSettings
  {
    IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB.Mechanical
{
  public partial class DuctSizeIterator
  {
    object IEnumerator.Current => throw new System.NotImplementedException();
  }

  public partial class DuctSizes
  {
    IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
  }

  public partial class DuctSizeSettingIterator
  {
    object IEnumerator.Current => throw new System.NotImplementedException();
  }

  public partial class DuctSizeSettings
  {
    IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB.Structure
{
  public partial class RebarContainer
  {
    IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
  }

  public partial class RebarContainerIterator
  {
    object IEnumerator.Current => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB.PointClouds
{
  public partial class PointCollection
  {
    IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
  }

  public partial class PointIterator
  {
    object IEnumerator.Current => throw new System.NotImplementedException();
  }

  public partial class CloudPoint
  {
    public static implicit operator XYZ(CloudPoint cp) => new(cp.X, cp.Y, cp.Z);
  }
}
