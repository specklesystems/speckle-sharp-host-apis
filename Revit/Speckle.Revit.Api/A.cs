using Speckle.ProxyGenerator;

namespace Speckle.Revit.Api
{
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

    public static TInterface? Cast<TInterface, TWrapped>(object instance)
      where TInterface : class
    {
      if (instance is TWrapped w)
      {
        return ProxyMap.CreateProxy<TInterface>(w);
      }

      return null;
    }
  }
}
