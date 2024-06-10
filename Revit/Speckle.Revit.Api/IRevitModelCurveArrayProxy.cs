using System.Collections;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.PointClouds;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;

namespace Speckle.Revit.Api;

[Proxy(
  typeof(ModelCurveArray),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator", "Item", "get_Item", "set_Item" }
)]
public partial interface IRevitModelCurveArrayProxy : IRevitModelCurveArray;

public partial class ModelCurveArrayProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public int Count => Size;

  public IEnumerator<IRevitModelCurve> GetEnumerator() =>
    new RevitModelCurveCollectionIterator(_Instance.ForwardIterator());

  private readonly struct RevitModelCurveCollectionIterator : IEnumerator<IRevitModelCurve>
  {
    private readonly ModelCurveArrayIterator _curveArrayIterator;

    public RevitModelCurveCollectionIterator(ModelCurveArrayIterator curveArrayIterator)
    {
      _curveArrayIterator = curveArrayIterator;
    }

    public void Dispose() => _curveArrayIterator.Dispose();

    public bool MoveNext() => _curveArrayIterator.MoveNext();

    public void Reset() => _curveArrayIterator.Reset();

    object IEnumerator.Current => Current;

    public IRevitModelCurve Current => new ModelCurveProxy((ModelCurve)_curveArrayIterator.Current);
  }

  public IRevitModelCurve this[int index]
  {
    get
    {
      var obj = _Instance.get_Item(index);
      return Mapster.TypeAdapter.Adapt<IRevitModelCurve>(obj);
    }
  }
}

[Proxy(
  typeof(CurveArray),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator", "Item", "get_Item", "set_Item" }
)]
public partial interface IRevitCurveArrayProxy : IRevitCurveArray;

public partial class CurveArrayProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public int Count => Size;

  public IEnumerator<IRevitCurve> GetEnumerator() =>
    new RevitCurveCollectionIterator(_Instance.ForwardIterator());

  private readonly struct RevitCurveCollectionIterator : IEnumerator<IRevitCurve>
  {
    private readonly CurveArrayIterator _curveArrayIterator;

    public RevitCurveCollectionIterator(CurveArrayIterator curveArrayIterator)
    {
      _curveArrayIterator = curveArrayIterator;
    }

    public void Dispose() => _curveArrayIterator.Dispose();

    public bool MoveNext() => _curveArrayIterator.MoveNext();

    public void Reset() => _curveArrayIterator.Reset();

    object IEnumerator.Current => Current;

    public IRevitCurve Current => new CurveProxy((Curve)_curveArrayIterator.Current);
  }

  public IRevitCurve this[int index]
  {
    get
    {
      var obj = _Instance.get_Item(index);
      return Mapster.TypeAdapter.Adapt<IRevitCurve>(obj);
    }
  }
}

[Proxy(
  typeof(DoubleArray),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator", "Item", "get_Item", "set_Item" }
)]
public partial interface IRevitDoubleArrayProxy : IRevitDoubleArray;

public partial class DoubleArrayProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public int Count => Size;

  public IEnumerator<double> GetEnumerator() =>
    new DoubleArrayProxyIterator(_Instance.ForwardIterator());

  private readonly struct DoubleArrayProxyIterator : IEnumerator<double>
  {
    private readonly DoubleArrayIterator _curveArrayIterator;

    public DoubleArrayProxyIterator(DoubleArrayIterator doubleArrayIterator)
    {
      _curveArrayIterator = doubleArrayIterator;
    }

    public void Dispose() => _curveArrayIterator.Dispose();

    public bool MoveNext() => _curveArrayIterator.MoveNext();

    public void Reset() => _curveArrayIterator.Reset();

    object IEnumerator.Current => Current;

    public double Current => (double)_curveArrayIterator.Current;
  }

  public double this[int index] => _Instance.get_Item(index);
}
public struct RevitCloudPoint : IRevitCloudPoint
{
  public float X  { get; }
  public float Y  { get; }
  public float Z  { get; }
  public int Color { get; }

  public RevitCloudPoint(float x, float y, float z, int color)
  {
    X = x;
    Y = y;
    Z = z;
    Color = color;
  }

  public IRevitXYZ ToXYZ() => new XYZProxy(new XYZ(X, Y, Z));
}
[Proxy(
  typeof(RevitCloudPoint),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitCloudPointProxy : IRevitCloudPointList;
[Proxy(
  typeof(PointCollection),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator", "Item", "get_Item", "set_Item" }
)]
public partial interface IRevitCloudPointListProxy : IRevitCloudPointList;

public partial class PointCollectionProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public IEnumerator<IRevitCloudPoint> GetEnumerator() =>
    new RevitCloudPointListIterator(_Instance.GetPointIterator());

  private readonly struct RevitCloudPointListIterator : IEnumerator<IRevitCloudPoint>
  {
    private readonly PointIterator _curveArrayIterator;

    public RevitCloudPointListIterator(PointIterator curveArrayIterator)
    {
      _curveArrayIterator = curveArrayIterator;
    }

    public void Dispose() => _curveArrayIterator.Dispose();

    public bool MoveNext() => _curveArrayIterator.MoveNext();

    public void Reset() => _curveArrayIterator.Reset();

    object IEnumerator.Current => Current;

    public IRevitCloudPoint Current
    {
      get
      {
        var current = _curveArrayIterator.Current;
        return new RevitCloudPoint(current.X, current.Y, current.Z, current.Color);
      }
    }
  }
}
