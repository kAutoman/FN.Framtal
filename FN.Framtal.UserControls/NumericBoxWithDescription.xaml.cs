using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for NumericBoxWithDescription.xaml
    /// </summary>
    public partial class NumericBoxWithDescription : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(NumericBoxWithDescription), new PropertyMetadata(OnTitlePropertyChanged));

        public string Title
        {
            get => GetValue(TitleProperty) as string;
            set => SetValue(TitleProperty, value);
        }

        public NumericBoxWithDescription()
        {
            InitializeComponent();
        }

        private static void OnTitlePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as NumericBoxWithDescription;
            var newValue = e.NewValue as string;
            control.TitleBlock.Text = newValue;
        }
    }
}
