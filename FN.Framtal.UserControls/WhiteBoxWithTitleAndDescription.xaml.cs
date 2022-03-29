using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    public partial class WhiteBoxWithTitleAndDescription : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(TitleText), typeof(string), typeof(WhiteBoxWithTitleAndDescription), new PropertyMetadata(OnTitlePropertyChanged));

        public static readonly DependencyProperty DescriptionProperty = DependencyProperty.Register(nameof(DescriptionText), typeof(string), typeof(WhiteBoxWithTitleAndDescription), new PropertyMetadata(OnDescriptionPropertyChanged));

        public string TitleText
        {
            get => GetValue(TitleProperty) as string;
            set => SetValue(TitleProperty, value);
        }

        public string DescriptionText
        {
            get => GetValue(DescriptionProperty) as string;
            set => SetValue(DescriptionProperty, value);
        }

        public WhiteBoxWithTitleAndDescription()
        {
            InitializeComponent();
        }

        private static void OnTitlePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var newValue = e.NewValue as string;

            ((WhiteBoxWithTitleAndDescription)d).TitleBlock.Text = newValue;
        }

        private static void OnDescriptionPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((WhiteBoxWithTitleAndDescription) d).DescriptionBlock.Text = e.NewValue as string;
        }
    }
}
