# speckle.xunit.runner.wpf

[![Build Status](https://teocomi.visualstudio.com/Speckle/_apis/build/status/specklesystems.speckle.xunit.runner.wpf?branchName=master)](https://teocomi.visualstudio.com/Speckle/_build/latest?definitionId=4&branchName=master)

XUnit Gui written in WPF

Fork of [xunit.runner.wpf](https://www.nuget.org/packages/xunit.runner.wpf).

This fork, uses the [AssemblyRunner](https://github.com/xunit/xunit/blob/main/src/xunit.v3.runner.utility/Runners/AssemblyRunner.cs) of xunit.v3.runner.utility to run the tests so that the external dlls are loaded via reflection in the same AppDomain.
This is necessary when running unit tests of code hosted by external applications (Revit etc).

NuGet package: https://www.nuget.org/packages/speckle.xunit.runner.wpf/

Sample application using it: https://github.com/Speckle-Next/xUnitRevit

Many thanks to all the developers of xunit and xunit.runner.wpf!



Check out our blog post on this 👉 https://speckle.systems/blog/xunitrevit !
