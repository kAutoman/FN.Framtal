using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for TextBoxWithBlackText.xaml
    /// </summary>
    public partial class TextBoxWithBlackText : UserControl
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(TextBoxWithBlackText), new PropertyMetadata(OnTextPropertyChanged));

        public string Text
        {
            get => GetValue(TextProperty) as string;
            set => SetValue(TextProperty, value);
        }

        public TextBoxWithBlackText()
        {
            InitializeComponent();
        }

        private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((TextBoxWithBlackText)d).BlackTextBlock.Text = e.NewValue as string;
        }
    }
}
