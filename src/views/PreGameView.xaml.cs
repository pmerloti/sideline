using sideline.models;
using sideline.viewmodels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace sideline.views
{
    public partial class PreGameView : Window
    {
        
        public PreGameView(OrganizationVM organizations)
        {
            InitializeComponent();
            DataContext = this;

            this.organizations = organizations;

            Squads = organizations.GetCurrentSquads();
        }


        public ReadOnlyObservableCollection<Tuple<string, TeamSquad>> Squads { get; set; }
        public TeamSquad HomeSquad { get; set; }
        public TeamSquad AwaySquad { get; set; }





        public OrganizationVM organizations;

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Home="+HomeSquad.Name+", Away="+AwaySquad.Name);

        }
    }
}
