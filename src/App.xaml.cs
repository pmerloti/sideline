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
        MainWindow mainView = new MainWindow();



        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleUnhandledException);

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
