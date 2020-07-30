# xunit.runner.wpf

[![Build Status](https://teocomi.visualstudio.com/Speckle/_apis/build/status/Speckle-Next.speckle.xunit.runner.wpf?branchName=master)](https://teocomi.visualstudio.com/Speckle/_build/latest?definitionId=1&branchName=master)

XUnit Gui written in WPF

Fork of [xunit.runner.wpf](https://www.nuget.org/packages/xunit.runner.wpf).

This version, currently in WIP, uses the [AssemblyRunner](xunit.v3.runner.utility) found in xunit.v3.runner.utility to run the tests so that the external dlls are loaded in the same AppDomain.
This is necessary when running unit tests of code hosted by external applications (Revit etc).

Coming soon, a xunit runner for Revit.
