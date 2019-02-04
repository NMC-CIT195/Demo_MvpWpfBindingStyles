using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Demo_MvpWpfBindingStyles.Views;
using Demo_MvpWpfBindingStyles.Presenters;

namespace Demo_MvpWpfBindingStyles
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindowPresenter mainWindowPresenter = new MainWindowPresenter();
            MainWindowView mainWindowView = new MainWindowView(mainWindowPresenter);

            mainWindowView.DataContext = mainWindowPresenter;

            mainWindowView.ShowDialog();
        }
    }
}
