using FluentAssertions;
using NUnit.Framework;
using Speckle.Shared;

namespace Speckle.Tests;

public class EnumUtilityTests
{
  public enum Test1
  {
    X = 1,
    Y = 2,
  }

  public enum Test2
  {
    X = 3,
    Y = 4
  }

  public enum Test3
  {
    X = 3,
    XX = 4
  }

  public enum Test4
  {
    X = 3,
    XX = 3,
    Y = 4
  }

  public enum NonDefined1
  {
    Xstandard,
    Ystandard
  }

  public enum NonDefined2
  {
    Xstandard,
    Ystandard
  }

  [Test]
  public void Works_1_2()
  {
    var x = EnumUtility<Test1, Test2>.Convert(Test1.X);
    x.Should().Be(Test2.X);
  }

  [Test]
  public void Works_1_3()
  {
    var x = EnumUtility<Test1, Test3>.Convert(Test1.X);
    x.Should().Be(Test3.X);
  }

  [Test]
  public void Works_2_4()
  {
    var x = EnumUtility<Test2, Test4>.Convert(Test2.Y);
    x.Should().Be(Test4.Y);
  }

  [Test]
  public void Works_4_2()
  {
    var x = EnumUtility<Test4, Test2>.Convert(Test4.XX);
    x.Should().Be(Test2.X);
  }

  [Test]
  public void Works_D1_D2()
  {
    var x = EnumUtility<NonDefined1, NonDefined2>.Convert(NonDefined1.Xstandard);
    x.Should().Be(NonDefined2.Xstandard);
  }
}
