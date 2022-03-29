using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    public partial class SlysatryggingVidHeimilisstorf : UserControl
    {
        public static readonly DependencyProperty HeaderTextProperty = DependencyProperty.Register(nameof(HeaderText), typeof(string), typeof(SlysatryggingVidHeimilisstorf), new PropertyMetadata(OnHeaderTextPropertyChanged));
        public static readonly DependencyProperty CheckBoxTextProperty = DependencyProperty.Register(nameof(CheckBoxText), typeof(string), typeof(SlysatryggingVidHeimilisstorf), new PropertyMetadata(OnCheckBoxTextPropertyChanged));

        public string HeaderText
        {
            get => GetValue(HeaderTextProperty) as string;
            set => SetValue(HeaderTextProperty, value);
        }

        public string CheckBoxText
        {
            get => GetValue(CheckBoxTextProperty) as string;
            set => SetValue(CheckBoxTextProperty, value);
        }

        public SlysatryggingVidHeimilisstorf()
        {
            InitializeComponent();

            HeaderTextBlock.Text = "Slysatrygging við heimilisstörf";
            CheckBoxTextBlock.Text = "Setjið X í reitinn ef óskað er slysatryggingar.";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // To be implemented
        }

        private static void OnHeaderTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((SlysatryggingVidHeimilisstorf) d).HeaderTextBlock.Text = e.NewValue as string;
        }

        private static void OnCheckBoxTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((SlysatryggingVidHeimilisstorf)d).CheckBoxTextBlock.Text = e.NewValue as string;
        }
    }
}
