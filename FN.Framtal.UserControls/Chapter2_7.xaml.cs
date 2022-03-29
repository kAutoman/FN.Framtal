using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    public partial class Chapter2_7 : UserControl
    {
        public static readonly DependencyProperty TitleTextProperty = DependencyProperty.Register(nameof(TitleText), typeof(string), typeof(Chapter2_7), new PropertyMetadata(OnTitleTextPropertyChanged));

        public static readonly DependencyProperty DescriptionTextProperty = DependencyProperty.Register(nameof(DescriptionText), typeof(string), typeof(Chapter2_7), new PropertyMetadata(OnDescriptionPropertyChanged));

        public static readonly DependencyProperty PrefixTextProperty = DependencyProperty.Register(nameof(PrefixText), typeof(string), typeof(Chapter2_7), new PropertyMetadata(OnPrefixTextPropertyChanged));

        public static readonly DependencyProperty TitleTextBlockWidthProperty = DependencyProperty.Register(nameof(TitleTextBlockWidth), typeof(double), typeof(Chapter2_7), new PropertyMetadata(OnTitleTextBlockWidthPropertyChanged));

        public static readonly DependencyProperty DescriptionTextBlockWidthProperty = DependencyProperty.Register(nameof(DescriptionTextBlockWidth), typeof(double), typeof(Chapter2_7), new PropertyMetadata(OnDescriptionTextBlockWidthPropertyChanged));

        public string TitleText
        {
            get => GetValue(TitleTextProperty) as string;
            set => SetValue(TitleTextProperty, value);
        }

        public string DescriptionText
        {
            get => GetValue(DescriptionTextProperty) as string;
            set => SetValue(DescriptionTextProperty, value);
        }

        public string PrefixText
        {
            get => GetValue(PrefixTextProperty) as string;
            set => SetValue(PrefixTextProperty, value);
        }

        public double TitleTextBlockWidth
        {
            get => (double)GetValue(TitleTextBlockWidthProperty);
            set => SetValue(TitleTextBlockWidthProperty, value);
        }

        public double DescriptionTextBlockWidth
        {
            get => (double)GetValue(DescriptionTextBlockWidthProperty);
            set => SetValue(DescriptionTextBlockWidthProperty, value);
        }

        public Chapter2_7()
        {
            InitializeComponent();
        }

        private static void OnTitleTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Chapter2_7)d).TitleTextBlock.Text = e.NewValue as string;
        }

        private static void OnDescriptionPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var newValue = e.NewValue as string;

            ((Chapter2_7)d).DescriptionTextBlock.Text = newValue;
        }

        private static void OnPrefixTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var newValue = e.NewValue as string;

            ((Chapter2_7)d).PrefixTextBlock.Text = newValue;
        }

        private static void OnTitleTextBlockWidthPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Chapter2_7)d).TitleTextBlock.Width = (double)e.NewValue;
        }

        private static void OnDescriptionTextBlockWidthPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Chapter2_7)d).DescriptionTextBlock.Width = (double)e.NewValue;
        }
    }
}
