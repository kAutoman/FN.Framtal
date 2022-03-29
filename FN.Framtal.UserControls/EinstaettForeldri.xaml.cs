using System;
using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    public partial class EinstaettForeldri : UserControl
    {
        public static readonly DependencyProperty TitleTextProperty = DependencyProperty.Register(nameof(TitleText), typeof(string), typeof(EinstaettForeldri), new PropertyMetadata(OnTitleTextPropertyChanged));
        public static readonly DependencyProperty CheckBoxTextProperty = DependencyProperty.Register(nameof(CheckBoxText), typeof(string), typeof(EinstaettForeldri), new PropertyMetadata(OnCheckBoxTextPropertyChanged));
        public static readonly DependencyProperty BottomTextProperty = DependencyProperty.Register(nameof(BottomText), typeof(string), typeof(EinstaettForeldri), new PropertyMetadata(OnBottomTextPropertyChanged));

        public string TitleText
        {
            get => GetValue(TitleTextProperty) as string;
            set => SetValue(TitleTextProperty, value);
        }

        public string CheckBoxText
        {
            get => GetValue(CheckBoxTextProperty) as string;
            set => SetValue(CheckBoxTextProperty, value);
        }

        public string BottomText
        {
            get => GetValue(BottomTextProperty) as string;
            set => SetValue(BottomTextProperty, value);
        }

        public EinstaettForeldri()
        {
            InitializeComponent();

            TitleTextBlock.Text = "Einstætt foreldri";
            CheckBoxTextBlock.Text = "Ef framteljandi er einstætt foreldri skal staðfesta það með því að setja X í þennan reit.";
            BottomTextBlock.Text = "Sjá nánari skýringar í leiðbeiningum.";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // To be implemented
        }

        private static void OnTitleTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((EinstaettForeldri)d).TitleTextBlock.Text = e.NewValue as string;
        }

        private static void OnCheckBoxTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((EinstaettForeldri)d).CheckBoxTextBlock.Text = e.NewValue as string;
        }

        private static void OnBottomTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((EinstaettForeldri)d).BottomTextBlock.Text = e.NewValue as string;
        }
    }
}
