﻿using sideline.models;
using sideline.viewmodels;
using System.Windows;

namespace sideline
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnRecordMatch_Click(object sender, RoutedEventArgs e)
        {
            var orgs = PersistentModel.Organizations;
            var preGameView = new views.PreGameView(new OrganizationVM(ref orgs));
            preGameView.Show();
        }

        private void BtnTeams_Click(object sender, RoutedEventArgs e)
        {
            var teamsView = new views.TeamsView();
            teamsView.Show();
        }

        private void BtnHistory_Click(object sender, RoutedEventArgs e)
        {
            var historyView = new views.HistoryView();
            historyView.Show();
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            var settingsView = new views.SettingsView();
            settingsView.Show();
        }
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
