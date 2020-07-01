using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xunit.Runner.Wpf
{
  public enum TestState
  {
    All = 0,
    NotRun = 1,
    Running = 2,
    Passed = 3,
    Skipped = 4,
    Failed = 5
  }
}
