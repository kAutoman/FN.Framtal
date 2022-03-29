using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FN.Framtal.UserControls
{
    public class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            PreviewTextInput += HandlePreviewTextInput;
            DataObject.AddPastingHandler(this, PastingHandler);
            TextAlignment = TextAlignment.Right;
        }

        private void HandlePreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!IsTextAllowed(e.Text))
            {
                return;
            }

            e.Handled = true;

            var oldCaretIndex = CaretIndex;
            var oldText = Text;

            var newText = oldText.Insert(oldCaretIndex, e.Text);
            Text = float.Parse(newText).ToString("N0");
            CaretIndex = oldCaretIndex + (Text.Length - oldText.Length);
        }

        private void PastingHandler(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                var text = e.DataObject.GetData(typeof(string)) as string;

                if (!IsTextAllowed(text))
                    e.CancelCommand();
            }
            else
            {
                e.CancelCommand();
            }
        }

        private static bool IsTextAllowed(string text)
        {
            return float.TryParse(text, out _);
        }
    }
}
