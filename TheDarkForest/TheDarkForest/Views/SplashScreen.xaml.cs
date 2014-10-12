namespace TheDarkForest.Views
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : UserControl
    {
        public const int DisplayDuration = 2000;

        public SplashScreen()
        {
            InitializeComponent();

            Trace.WriteLine(String.Format("Image thinks it's in {0}", brush.ImageSource.ToString()));
        }

        private void WelcomeTextOnLoadedCenter(object sender, RoutedEventArgs e)
        {
            double windowWidth = SystemParameters.PrimaryScreenWidth;

            var welcomeTextLeft = (windowWidth - this.WelcomeText.ActualWidth) / 2;

            Canvas.SetLeft(this.WelcomeText, welcomeTextLeft);
            Canvas.SetTop(this.WelcomeText, 100);
        }
    }
}