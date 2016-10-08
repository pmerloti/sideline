using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace sideline
{
    public partial class App : Application
    {
        DispatcherTimer timer = new DispatcherTimer();
        views.SplashView splashView = new views.SplashView();
        MainWindow mainView = new MainWindow();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleUnhandledException);

            const bool showSplash = true;

            if (showSplash)
            {
                splashView.Show();

                timer.Interval = TimeSpan.FromSeconds(3);
                timer.Tick += TimerShowMain;

                timer.Start();
            }
            else
                mainView.Show();

        }

        private void TimerShowMain(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= TimerShowMain;

            mainView.Show();

            timer.Tick += TimerCloseSplash;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        private void TimerCloseSplash(object sender, EventArgs e)
        {
            timer.Stop();

            splashView.Close();
        }

        void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = (e.ExceptionObject as Exception);
            MessageBox.Show("Pardon our dust... something went wrong.\n" + ex.Message + "\n" + ex.StackTrace,
                            "Unhandled Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

    }
}
