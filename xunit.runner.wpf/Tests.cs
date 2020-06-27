using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Xunit.Runner.Wpf
{
  public class Tests
  {
    [Fact]
    //[Trait("TraitName1", "TraitValue1")]
    public void Pass()
    {
      Thread.Sleep(TimeSpan.FromSeconds(1));
    }
    [Fact]
    public void Pass2()
    {
      Thread.Sleep(TimeSpan.FromSeconds(3));
    }
    [Fact]
    public void Pass3()
    {
      Thread.Sleep(TimeSpan.FromSeconds(3));
    }

    [Fact]
    //[Trait("TraitName1", "TraitValue2")]
    public void Fail()
    {
      Thread.Sleep(TimeSpan.FromSeconds(1));
      Assert.True(false);
    }

    [Fact(Skip = "Testing")]
    //[Trait("TraitName2", "TraitValue2")]
    public void Skip()
    {
      Thread.Sleep(TimeSpan.FromSeconds(1));
    }
  }
}
