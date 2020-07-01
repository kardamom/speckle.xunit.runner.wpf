using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Xunit.Runner.Wpf;

namespace Launcher
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);

      var main = new MainWindow();
      main.Title = "xUnit Revit by Speckle";
      main.Show();
    }
  }
}
