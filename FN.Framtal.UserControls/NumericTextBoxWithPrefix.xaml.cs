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
    /// Interaction logic for NumericTextBoxWithPrefix.xaml
    /// </summary>
    public partial class NumericTextBoxWithPrefix : UserControl
    {
        public static readonly DependencyProperty PrefixTextProperty = DependencyProperty.Register(nameof(PrefixText), typeof(string), typeof(NumericTextBoxWithPrefix), new PropertyMetadata(OnPrefixTextPropertyChanged));

        public static readonly DependencyProperty IsReadOnlyProperty = DependencyProperty.Register(nameof(IsReadOnly), typeof(bool), typeof(NumericTextBoxWithPrefix), new PropertyMetadata(OnIsReadOnlyPropertyChanged));

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(NumericTextBoxWithPrefix), new PropertyMetadata(OnTextPropertyChanged));

        public string PrefixText
        {
            get => GetValue(PrefixTextProperty) as string;
            set => SetValue(PrefixTextProperty, value);
        }

        public string Text
        {
            get => GetValue(TextProperty) as string;
            set => SetValue(TextProperty, value);
        }


        public bool IsReadOnly
        {
            get => (bool)GetValue(IsReadOnlyProperty);
            set => SetValue(IsReadOnlyProperty, value);
        }

        public NumericTextBoxWithPrefix()
        {
            InitializeComponent();

            NumericTextBox.TextChanged += OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Text = NumericTextBox.Text;
        }

        private static void OnPrefixTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as NumericTextBoxWithPrefix;
            var newValue = e.NewValue as string;
            control.PrefixTextBlock.Text = newValue;
        }
        
        private static void OnIsReadOnlyPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as NumericTextBoxWithPrefix;
            var newValue = (bool)e.NewValue;
            control.NumericTextBox.IsReadOnly = newValue;
        }

        private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as NumericTextBoxWithPrefix;
            var newValue = e.NewValue as string;
            control.NumericTextBox.Text = newValue;
        }
    }
}
