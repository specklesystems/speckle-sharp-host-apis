namespace Rhino;

public partial interface IEpsilonComparable<T>
{
  public System.Boolean EpsilonEquals(T other, System.Double epsilon);
}
