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
    /// Interaction logic for IntegerControl.xaml
    /// </summary>
    public partial class IntegerControl : UserControl
    {
        public IntegerControl()
        {
            InitializeComponent();
            PreviewTextInput += HandlePreviewTextInput;
            txtIntegerBox.TextChanged += HandleTextChangeText;
            DataObject.AddPastingHandler(this, PastingHandler);
        }

        private void HandlePreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out _);
        }

       private void HandleTextChangeText(object sender, TextChangedEventArgs e)
       {
           if (!e.Handled)
           {
                var text = txtIntegerBox.Text.Replace(".", "");
                txtIntegerBox.Text = GetThousandSeparetedValue(text);
                this.txtIntegerBox.Select(txtIntegerBox.Text.Length, 0);
                this.txtIntegerBox.Focus();
                txtIntegerBox.CaretIndex = txtIntegerBox.Text.Length;
                txtIntegerBox.TextAlignment = TextAlignment.Right;
            }
       }

        private void PastingHandler(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                var text = e.DataObject.GetData(typeof(string)) as string;
                
                if (!IsTextAllowed(text))
                    e.CancelCommand();

                e.DataObject.SetData(GetThousandSeparetedValue(text));
            }
            else
            {
                e.CancelCommand();
            }
        }

        private string GetThousandSeparetedValue(string text)
        {
            text = text.Replace(".", "");
            for (int i = text.Length - 3; i > 0; i = i - 3)
            {
                text = text.Insert(i, ".");
            }

            return text;
        }

        private static bool IsTextAllowed(string text)
        {
            return int.TryParse(text, out _);
        }

    }
}
