using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xunit.Runner.Wpf.ViewModel;

namespace Xunit.Runner.Wpf
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {



    public MainWindow()
    {
      //in case it's loaded by an external application
      this.DataContext = new ViewModelLocator().Main;
      InitializeComponent();
    }




    private void TestCases_SelectionChanged(Object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
      foreach (var item in e.AddedItems)
      {
        var model = item as TestCaseViewModel;
        if (model != null)
        {
          model.IsSelected = true;
        }
      }

      foreach (var item in e.RemovedItems)
      {
        var model = item as TestCaseViewModel;
        if (model != null)
        {
          model.IsSelected = false;
        }
      }
    }
  }
}
