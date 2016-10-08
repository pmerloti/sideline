using System;
using System.Windows;
using System.Windows.Threading;

namespace sideline.views
{
    public partial class SplashView : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public SplashView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
