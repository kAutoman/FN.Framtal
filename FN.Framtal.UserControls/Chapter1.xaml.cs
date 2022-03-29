using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for Chapter1.xaml
    /// </summary>
    public partial class Chapter1 : UserControl
    {

        public static readonly DependencyProperty ChapterNumberProperty = DependencyProperty.Register(nameof(ChapterNumber), typeof(string), typeof(Chapter1), new PropertyMetadata(OnChapterNumberPropertyChanged));

        public static readonly DependencyProperty ChapterTextProperty = DependencyProperty.Register(nameof(ChapterText), typeof(string), typeof(Chapter1), new PropertyMetadata(OnChapterTextPropertyChanged));

       
        public string ChapterNumber
        {
            get => GetValue(ChapterNumberProperty) as string;
            set => SetValue(ChapterNumberProperty, value);
        }

        public string ChapterText
        {
            get => GetValue(ChapterTextProperty) as string;
            set => SetValue(ChapterTextProperty, value);
        }

        public Chapter1()
        {
            InitializeComponent();
        }

        private static void OnChapterNumberPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Chapter1) d).ChapterNumberTextBlock.Text = e.NewValue as string;
        }

        private static void OnChapterTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Chapter1) d).ChapterTextBlock.Text = e.NewValue as string;
        }
    }
}
