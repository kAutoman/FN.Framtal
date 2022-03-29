using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    public partial class Chapter2 : UserControl
    {
        public static readonly DependencyProperty ChapterNumberProperty = DependencyProperty.Register(nameof(ChapterNumber), typeof(string), typeof(Chapter2), new PropertyMetadata(OnChapterNumberPropertyChanged));

        public string ChapterNumber
        {
            get => GetValue(ChapterNumberProperty) as string;
            set => SetValue(ChapterNumberProperty, value);
        }

        public Chapter2()
        {
            InitializeComponent();
        }

        private static void OnChapterNumberPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Chapter2)d).ChapterNumberTextBlock.Text = e.NewValue as string;
        }
    }
}
