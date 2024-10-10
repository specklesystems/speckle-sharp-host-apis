namespace Rhino;

public partial interface IEpsilonFComparable<T>
{
  public System.Boolean EpsilonEquals(T other, System.Single epsilon);
}
