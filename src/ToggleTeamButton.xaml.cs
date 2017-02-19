using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace sideline
{
    public partial class ToggleTeamButton : UserControl
	{
		public ToggleTeamButton()
		{
			this.InitializeComponent();
            IsOn = false;

		}


        private static void OnBackgroundChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {

        }

        public static DependencyProperty IsOnProperty = DependencyProperty.Register("IsOn", typeof(bool?), typeof(ToggleTeamButton), null);
        public bool? IsOn
        {
            get { return (bool?)GetValue(IsOnProperty); }
            set { SetValue(IsOnProperty, value); }
        }

        public static DependencyProperty BackgroundColorProperty = 
            DependencyProperty.Register(
                "BackgroundColor", 
                typeof(SolidColorBrush), 
                typeof(ToggleTeamButton), 
                new PropertyMetadata(new SolidColorBrush(Colors.Yellow), new PropertyChangedCallback(OnBackgroundChanged)));
        public SolidColorBrush BackgroundColor
        {
            get { return (SolidColorBrush)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }
    }
}