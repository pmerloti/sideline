using sideline.models;
using System;
using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace sideline
{
    public partial class App : Application
    {
        MainWindow mainView = new MainWindow();



        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleUnhandledException);


            //DEBUG
            //Season season = new Season()
            //{
            //    Name = "2016 Fall Season"
            //};

            //Team t = new Team()
            //{
            //    TeamName = "Tigers",
            //    LongName = "Fury Indoor Girls Tigers Squad",
            //    Gender = "Girls",
            //    Mascot = "Jaguar",
            //    OverallRecordOverride = "5-4"
            //};

            //TeamSeason ts = new TeamSeason(t, season)
            //{
            //    AgeBracket = "14U",
            //    HeadCoach = "Oscar Munoz",
            //    AssistantCoach = "Briana Gonzalez",
            //    Colors = "White/Blue"
            //};
            
            //var path = Path.Combine(CommonConfig.TeamsFolder, ts.GetUniqueName() + ".json");
            //string json = JsonConvert.SerializeObject(ts, Formatting.Indented);
            //File.WriteAllText(path, json);
            //DEBUG

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
