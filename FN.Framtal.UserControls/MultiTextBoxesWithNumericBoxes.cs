using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FN.Framtal.UserControls
{
    public class MultiTextBoxesWithNumericBoxes : MultiTextBoxes
    {
        protected override UIElement GetNewChild()
        {
            var grid = new Grid();

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var textBox = GetNewTextBox<TextBox>();
           // var intControl = new IntegerControl().ucIntegerControl; 
           // var numericTextBox = GetNewTextBox<intControl.Int>();
            var numericTextBox = GetNewTextBox<NumericTextBox>();

            textBox.SetValue(Grid.ColumnProperty, 0);
            textBox.SetValue(MarginProperty, new Thickness(0, 0, 5, 0));
            numericTextBox.SetValue(Grid.ColumnProperty, 1);


            grid.Children.Add(textBox);
            grid.Children.Add(numericTextBox);

            return grid;
        }
    }
}
