using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for ResultBox.xaml
    /// </summary>
    public partial class ResultBox : UserControl
    {
        public static readonly DependencyProperty PrefixTextProperty = DependencyProperty.Register(nameof(PrefixText), typeof(string), typeof(ResultBox), new PropertyMetadata(OnPrefixTextPropertyChanged));
        public static readonly DependencyProperty PrefixBackGroundColorProperty = DependencyProperty.Register(nameof(PrefixBackGroundColor), typeof(Brush), typeof(ResultBox), new PropertyMetadata(PrefixBackGroundColorPropertyChanged));
        public static readonly DependencyProperty ResultBackGroundColorProperty = DependencyProperty.Register(nameof(ResultBackGroundColor), typeof(Brush), typeof(ResultBox), new PropertyMetadata(ResultBackGroundColorPropertyChanged));

        public string PrefixText
        {
            get => GetValue(PrefixTextProperty) as string;
            set => SetValue(PrefixTextProperty, value);
        }

        public Brush PrefixBackGroundColor
        {
            get => GetValue(PrefixBackGroundColorProperty) as Brush;
            set => SetValue(PrefixBackGroundColorProperty, value);
        }

        public Brush ResultBackGroundColor
        {
            get => GetValue(ResultBackGroundColorProperty) as Brush;
            set => SetValue(ResultBackGroundColorProperty, value);
        }

        public ResultBox()
        {
            InitializeComponent();
        }

        private static void OnPrefixTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ResultBox)d).PrefixTextBlock.Text = e.NewValue as string;
        }

        private static void PrefixBackGroundColorPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ResultBox)d).PrefixTextBlockBorder.Background = e.NewValue as Brush;
        }

        private static void ResultBackGroundColorPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ResultBox)d).NumericTextBoxBorder.Background = e.NewValue as Brush;
        }
    }
}
