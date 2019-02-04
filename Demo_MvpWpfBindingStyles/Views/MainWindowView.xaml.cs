using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Demo_MvpWpfBindingStyles.Presenters;

namespace Demo_MvpWpfBindingStyles.Views
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        MainWindowPresenter _mainWindowPresenter;

        public MainWindowView(MainWindowPresenter mainWindowPresenter)
        {
            _mainWindowPresenter = mainWindowPresenter;

            InitializeComponent();
        }
    }
}
