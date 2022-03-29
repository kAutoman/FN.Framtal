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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for TextBoxWithDescription.xaml
    /// </summary>
    public partial class TextBoxWithDescription : UserControl
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(TextBoxWithDescription), new PropertyMetadata(OnTextPropertyChanged));

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(TextBoxWithDescription), new PropertyMetadata(OnTitlePropertyChanged));

        public static readonly DependencyProperty HasBackgroundColorProperty = DependencyProperty.Register(nameof(HasBackgroundColor), typeof(bool), typeof(TextBoxWithDescription), new PropertyMetadata(true));

        public static readonly DependencyProperty TextBoxVisibleProperty = DependencyProperty.Register(nameof(TextBoxVisible), typeof(bool), typeof(TextBoxWithDescription), new PropertyMetadata(true, OnTextBoxVisiblePropertyChanged));

        public string Text
        {
            get => GetValue(TextProperty) as string;
            set => SetValue(TextProperty, value);
        }

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
        
        public bool TextBoxVisible
        {
            get => (bool)GetValue(TextBoxVisibleProperty);
            set => SetValue(TextBoxVisibleProperty, value);
        }

        public TextBoxWithDescription()
        {
            InitializeComponent();

            TextBox.TextChanged += OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Text = TextBox.Text;
        }

        private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as TextBoxWithDescription).TextBox.Text = e.NewValue as string;
        }

        private static void OnTitlePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as TextBoxWithDescription;
            var newValue = e.NewValue as string;
            control.TitleBlock.Text = newValue;
            control.TitleBlock.Visibility = !string.IsNullOrEmpty(newValue) ? Visibility.Visible : Visibility.Collapsed;
        } 
        
        private static void OnTextBoxVisiblePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var newValue = (bool)e.NewValue;
            (d as TextBoxWithDescription).TextBox.Visibility = newValue ? Visibility.Visible : Visibility.Hidden;
        }

        
    }
}
