using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for ContentWithDescription.xaml
    /// </summary>
    
    [ContentProperty(nameof(Body))]
    public partial class ContentWithDescription : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(ContentWithDescription), new PropertyMetadata(OnTitlePropertyChanged));

        public static readonly DependencyProperty HasBackgroundColorProperty = DependencyProperty.Register(nameof(HasBackgroundColor), typeof(bool), typeof(ContentWithDescription), new PropertyMetadata(true));

        public static readonly DependencyProperty BackgroundColorProperty = DependencyProperty.Register(nameof(BackgroundColor), typeof(Brush), typeof(ContentWithDescription), new PropertyMetadata(OnBackgroundColorPropertyChanged));


        public static readonly DependencyProperty BodyProperty = DependencyProperty.Register(nameof(Body), typeof(object), typeof(ContentWithDescription), new PropertyMetadata(OnBodyPropertyChanged));


        public string Title
        {
            get => GetValue(TitleProperty) as string;
            set => SetValue(TitleProperty, value);
        }

        public bool HasBackgroundColor
        {
            get => (bool)GetValue(HasBackgroundColorProperty);
            set => SetValue(HasBackgroundColorProperty, value);
        }

        public object Body
        {
            get => GetValue(BodyProperty);
            set => SetValue(BodyProperty, value);
        }

        public Brush BackgroundColor
        {
            get => GetValue(BackgroundColorProperty) as Brush;
            set => SetValue(BackgroundColorProperty, value);
        }


        public ContentWithDescription()
        {
            InitializeComponent();
        }

        private static void OnTitlePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ContentWithDescription;
            var newValue = e.NewValue as string;
            control.TitleBlock.Text = newValue;
            control.TitleBlock.Visibility = !string.IsNullOrEmpty(newValue) ? Visibility.Visible : Visibility.Collapsed;
        }

        private static void OnBodyPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ContentWithDescription;
            control.ContentControl.Content = e.NewValue;
        }
        
        private static void OnBackgroundColorPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ContentWithDescription;

            if (control.HasBackgroundColor)
                control.MainBorder.Background = (Brush)e.NewValue;
        }
    }
}
