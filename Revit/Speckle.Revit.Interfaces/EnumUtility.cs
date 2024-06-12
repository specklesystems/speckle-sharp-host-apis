using System.Collections.Concurrent;

namespace Speckle.Revit.Interfaces
{
  public static class EnumUtility<TSource, TDestination>
    where TSource : struct, Enum
    where TDestination : struct, Enum
  {
    private static readonly ConcurrentDictionary<TSource, TDestination> _destinations = new();

    static EnumUtility()
    {
      var sources = ((TSource[])Enum.GetValues(typeof(TSource))).Select(x => (x.ToString(), x));
      var destinations = Enum.GetNames(typeof(TDestination))
        .Select(x => (x, (TDestination)Enum.Parse(typeof(TDestination), x.ToString())))
        .ToList();
      foreach (var (name, val) in sources)
      {
        var d = destinations.Where(x => x.Item1 == name).ToList();
        if (d.Any())
        {
          foreach (var v in d)
          {
            destinations.Remove(v);
          }
          _destinations.TryAdd(val, d.Single().Item2);
        }
      }
    }

    public static TDestination Convert(TSource source)
    {
      if (_destinations.TryGetValue(source, out var destination))
      {
        return destination;
      }

      throw new InvalidOperationException($"{source} does not exist in destination enum: {typeof(TDestination)}");
    }
  }
}
