using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace sideline
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleUnhandledException);


            var splashView = new SplashView();

            splashView.WindowStartupLocation = WindowStartupLocation.Manual;
            splashView.Show();

            Thread.Sleep(2000);

            var mainView = new MainWindow();

            splashView.Close();


            mainView.Show();

        }

        void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = (e.ExceptionObject as Exception);
            MessageBox.Show("Pardon our dust... something went wrong.\n" + ex.Message + "\n" + ex.StackTrace,
                            "Unhandled Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

    }
}
