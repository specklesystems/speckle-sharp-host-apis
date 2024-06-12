using FluentAssertions;
using NUnit.Framework;
using Speckle.Revit.Interfaces;

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

  [Test]
  public void Works()
  {
    var x = EnumUtility<Test1, Test2>.Convert(Test1.X);
    x.Should().Be(Test2.X);
  }
  
  [Test]
  public void Fails()
  {
    Assert.Throws<TypeInitializationException>(() =>
    {
      var x = EnumUtility<Test1, Test3>.Convert(Test1.X);
      x.Should().Be(Test3.X);
    });
  }
}
