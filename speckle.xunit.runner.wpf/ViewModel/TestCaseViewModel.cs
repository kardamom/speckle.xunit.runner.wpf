using System.Collections.Generic;
using System.Collections.Immutable;
using GalaSoft.MvvmLight;
using Xunit.Abstractions;
using Xunit.Runner.Wpf;

namespace Xunit.Runner.Wpf.ViewModel
{
  public class TestCaseViewModel : ViewModelBase
  {
    private TestState _state = TestState.NotRun;
    private string _output = "";
    private string _execTime = "";

    public string DisplayName { get; }
    public string UniqueID { get; }
    public string SkipReason { get; }
    public string AssemblyFileName { get; }
    public string AssemblyPath { get; }
    public ImmutableArray<TraitViewModel> Traits { get; }
    public bool IsSelected { get; set; }

    public bool HasSkipReason => !string.IsNullOrEmpty(this.SkipReason);

    public ITestCase TestCase { get; }

    public TestState State
    {
      get { return _state; }
      set { Set(ref _state, value); }
    }

    public string ExecutionTime
    {
      get { return _execTime; }
      set
      {
        Set(ref _execTime, value);
      }
    }

    public string Output
    {
      get { return _output; }
      set
      {
        Set(ref _output, value);
      }
    }

    public TestCaseViewModel(string displayName, string uniqueID, string skipReason, string assemblyFileName, string assemblyPath, ITestCase testCase, IEnumerable<TraitViewModel> traits)
    {
      this.DisplayName = displayName;
      this.UniqueID = uniqueID;
      this.SkipReason = skipReason;
      this.AssemblyFileName = assemblyFileName;
      this.AssemblyPath = assemblyPath;
      this.TestCase = testCase;
      this.Traits = traits.ToImmutableArray();

      if (!string.IsNullOrEmpty(skipReason))
      {
        _state = TestState.Skipped;
      }
    }
  }
}
