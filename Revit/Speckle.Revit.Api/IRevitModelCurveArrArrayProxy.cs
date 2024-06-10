﻿using System.Collections;
using Autodesk.Revit.DB;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;

namespace Speckle.Revit.Api;

[Proxy(
  typeof(ModelCurveArrArray),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator", "Item", "get_Item", "set_Item" }
)]
public partial interface IRevitModelCurveArrArrayProxy : IRevitModelCurveArrArray;

public partial class ModelCurveArrArrayProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public int Count => Size;

  public IEnumerator<IRevitModelCurveArray> GetEnumerator() =>
    new RevitModelCurveArrayIterator(_Instance.ForwardIterator());

  private readonly struct RevitModelCurveArrayIterator : IEnumerator<IRevitModelCurveArray>
  {
    private readonly ModelCurveArrArrayIterator _curveArrayIterator;

    public RevitModelCurveArrayIterator(ModelCurveArrArrayIterator curveArrayIterator)
    {
      _curveArrayIterator = curveArrayIterator;
    }

    public void Dispose() => _curveArrayIterator.Dispose();

    public bool MoveNext() => _curveArrayIterator.MoveNext();

    public void Reset() => _curveArrayIterator.Reset();

    object IEnumerator.Current => Current;

    public IRevitModelCurveArray Current => new ModelCurveArrayProxy((ModelCurveArray)_curveArrayIterator.Current);
  }

  public IRevitModelCurveArray this[int index]
  {
    get
    {
      var obj = _Instance.get_Item(index);
      return Mapster.TypeAdapter.Adapt<IRevitModelCurveArray>(obj);
    }
  }
}

[Proxy(
  typeof(CurveArrArray),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator", "Item", "get_Item", "set_Item" }
)]
public partial interface IRevitCurveArrArrayProxy : IRevitCurveArrArray;

public partial class CurveArrArrayProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public int Count => Size;

  public IEnumerator<IRevitCurveArray> GetEnumerator() =>
    new RevitCurveArrayIterator(_Instance.ForwardIterator());

  private readonly struct RevitCurveArrayIterator : IEnumerator<IRevitCurveArray>
  {
    private readonly CurveArrArrayIterator _curveArrayIterator;

    public RevitCurveArrayIterator(CurveArrArrayIterator curveArrayIterator)
    {
      _curveArrayIterator = curveArrayIterator;
    }

    public void Dispose() => _curveArrayIterator.Dispose();

    public bool MoveNext() => _curveArrayIterator.MoveNext();

    public void Reset() => _curveArrayIterator.Reset();

    object IEnumerator.Current => Current;

    public IRevitCurveArray Current => new CurveArrayProxy((CurveArray)_curveArrayIterator.Current);
  }

  public IRevitCurveArray this[int index]
  {
    get
    {
      var obj = _Instance.get_Item(index);
      return Mapster.TypeAdapter.Adapt<IRevitCurveArray>(obj);
    }
  }
}
