using System.Windows;

namespace sideline.views
{
    public partial class TeamsView : Window
    {
        public TeamsView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Add Team");

        }
    }
}
