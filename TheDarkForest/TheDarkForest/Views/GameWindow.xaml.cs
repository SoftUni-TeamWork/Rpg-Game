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
using System.Windows.Shapes;

namespace TheDarkForest.Views
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private async void SplashScreenOnLoadedSwitchToMenuView(object sender, RoutedEventArgs e)
        {
            await Task.Delay(SplashScreen.DisplayDuration);
            this.MainPanel.Children.Clear();
            this.MainPanel.Children.Add(new StartMenuScreen());
        }
    }
}