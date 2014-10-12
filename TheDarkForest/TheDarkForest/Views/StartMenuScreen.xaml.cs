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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TheDarkForest.Views
{
    /// <summary>
    /// Interaction logic for StartMenuScreen.xaml
    /// </summary>
    public partial class StartMenuScreen : UserControl
    {
        public StartMenuScreen()
        {
            InitializeComponent();
        }

        private void ButtonOnClickExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOnClickStart(object sender, RoutedEventArgs e)
        {
            var stackPanel = (StackPanel)Application.Current.MainWindow.Content;
            stackPanel.Children.Add(new GameField());
            stackPanel.Children.Remove(this);
        }
    }
}
