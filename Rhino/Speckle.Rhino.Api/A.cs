using Speckle.ProxyGenerator;

namespace Speckle.Rhino7.Api;

public static class A
{
  public static T? Call<T>(Func<object?> call)
    where T : class
  {
    var obj = call();
    if (obj is null)
    {
      return null;
    }

    return ProxyMap.CreateProxy<T>(obj);
  }

  public static TInterface? Cast<TInterface, THostType>(object instance)
  {
    if (instance is THostType w)
    {
      return ProxyMap.CreateProxy<TInterface>(w);
    }

    return default;
  }

  public static THostType? Cast<TProxy, THostType>(object? instance, Func<TProxy, THostType> proxyCast)
  {
    if (instance is TProxy w)
    {
      return proxyCast(w);
    }

    return default;
  }

  public static TProxy To<TProxy>(this object instance)
  {
    if (instance is TProxy w)
    {
      return w;
    }

    throw new NotSupportedException();
  }
}
