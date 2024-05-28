using Ninject;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var diContainer = new CalculatorDIContainer();
            MainWindow = diContainer.Get<MainWindow>();
            MainWindow.Show();
        }
    }

}
