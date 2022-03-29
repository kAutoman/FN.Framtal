using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FN.Framtal.UserControls
{
    public class MultiTextBoxes_Chapter_1_1 : MultiTextBoxes
    {
        protected override UIElement GetNewChild()
        {
            var grid = new Grid();

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(40, GridUnitType.Pixel) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            
            var checkbox = CreateNewCheckbox();
            var textBox1 = GetNewTextBox<TextBox>();
            var textBox2 = GetNewTextBox<TextBox>();
            var textBox3 = GetNewTextBox<TextBox>();

            var checkContent = new ContentWithDescription { Content = checkbox, HorizontalAlignment = HorizontalAlignment.Stretch };
            var content1 = new ContentWithDescription { Content = textBox1, HorizontalAlignment = HorizontalAlignment.Stretch };
            var content2 = new ContentWithDescription { Content = textBox2, HorizontalAlignment = HorizontalAlignment.Stretch };
            var content3 = new ContentWithDescription { Content = textBox3, HorizontalAlignment = HorizontalAlignment.Stretch };


            checkContent.SetValue(Grid.ColumnProperty, 0);
            content1.SetValue(Grid.ColumnProperty, 1);
            content2.SetValue(Grid.ColumnProperty, 2);
            content3.SetValue(Grid.ColumnProperty, 3);

            grid.Children.Add(checkContent);
            grid.Children.Add(content1);
            grid.Children.Add(content2);
            grid.Children.Add(content3);

            return grid;
        }

        private UIElement CreateNewCheckbox()
        {
            var grid = new Grid();

            var textbox = GetNewTextBox<TextBox>() as TextBox;
            textbox.IsEnabled = false;
            textbox.IsReadOnly = true;
            textbox.IsReadOnlyCaretVisible = false;

            var checkbox = new CheckBox { HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center };

            grid.Children.Add(textbox);
            grid.Children.Add(checkbox);

            return grid;
        }
    }
}
