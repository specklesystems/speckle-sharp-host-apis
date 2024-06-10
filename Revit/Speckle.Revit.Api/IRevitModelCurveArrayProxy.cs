using System.Collections;
using Autodesk.Revit.DB;
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
