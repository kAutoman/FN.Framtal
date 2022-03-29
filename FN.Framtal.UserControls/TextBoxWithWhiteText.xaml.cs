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
    /// Interaction logic for TextBoxWithWhiteText.xaml
    /// </summary>
    public partial class TextBoxWithWhiteText : UserControl
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(TextBoxWithWhiteText), new PropertyMetadata(OnTextPropertyChanged));



        public string Text
        {
            get => GetValue(TextProperty) as string;
            set => SetValue(TextProperty, value);
        }

        public TextBoxWithWhiteText()
        {
            InitializeComponent();
        }

        private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as TextBoxWithWhiteText).WhiteTextBlock.Text = e.NewValue as string;
        }
    }
}
