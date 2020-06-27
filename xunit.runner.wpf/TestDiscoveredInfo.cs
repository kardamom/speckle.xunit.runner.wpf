using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Xunit.Runner.Wpf
{
  public class TestDiscoveryInfo
  {
    public IEnumerable<ITestCase> Cases { get; set; }
    public string AssemblyFileName { get; set; }

    public TestDiscoveryInfo(IEnumerable<ITestCase> cases, string assemblyFileName)
    {
      Cases = cases;
      AssemblyFileName = assemblyFileName;
    }
  }
}
