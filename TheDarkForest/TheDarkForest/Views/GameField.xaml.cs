﻿using System;
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
    /// Interaction logic for GameFieldView.xaml
    /// </summary>
    public partial class GameField : UserControl
    {
        public GameField()
        {
            InitializeComponent();
        }

        private void CanvasOnLoadedSetSizeToWindow(object sender, RoutedEventArgs e)
        {
            var canvas = (Canvas)sender;

            canvas.Width = Application.Current.MainWindow.ActualWidth;
            canvas.Height = Application.Current.MainWindow.ActualHeight;
        }
    }
}