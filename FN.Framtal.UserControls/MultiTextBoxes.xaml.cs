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
    /// Interaction logic for MultiTextBoxes.xaml
    /// </summary>
    public partial class MultiTextBoxes : UserControl
    {
        public static readonly DependencyProperty InitialTextBoxesCountProperty = DependencyProperty.Register(nameof(InitialTextBoxesCount), typeof(int), typeof(MultiTextBoxes), new PropertyMetadata(5, OnInitialTextBoxesCountPropertyChanged));

        public event EventHandler<TextChangedEventArgs> TextChanged;

        public IReadOnlyList<TextBox> TextBoxes => _textBoxes;

        private readonly List<TextBox> _textBoxes;

        public int InitialTextBoxesCount
        {
            get => (int)GetValue(InitialTextBoxesCountProperty);
            set => SetValue(InitialTextBoxesCountProperty, value);
        }

        public MultiTextBoxes()
        {
            InitializeComponent();
            _textBoxes = new List<TextBox>();
            CreateInitialChildren();
        }


        private void CreateInitialChildren()
        {
            var count = InitialTextBoxesCount;

            for (int i = 0; i < count; i++)
            {
                AddChild();
            }
        }

        // Function that adds a new Child to the main StackPanel
        // by calling GetNewChild()
        private void AddChild()
        {
            var textBox = GetNewChild();

            MainStackPanel.Children.Add(textBox);
        }

        // Function that returns a new Child (TextBox by default) by calling
        // GetNewTextBox. This can be overriden by other controls to supply a
        // different Child than TextBox if needed (for eg. NumericOnlyTextBox, or
        // ContentWithDescription)
        protected virtual UIElement GetNewChild()
        {
            return GetNewTextBox<TextBox>();
        }

        // Function that creates a new TextBox
        protected UIElement GetNewTextBox<T>() where T : TextBox
        {
            var textBox = Activator.CreateInstance<T>();

            textBox.Style = Resources["TableTextBoxStyle"] as Style;

            // We listen to the changes to the text of the created TextBox
            textBox.TextChanged += OnTextBoxTextChanged;

            _textBoxes.Add(textBox);

            return textBox;
        }

        // Triggers when Text changes in any TextBox
        protected void OnTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            if (MainStackPanel.Children.Count == 0)
                return;

            TextChanged?.Invoke(sender, e);

            // We get the last Child (TextBox or a control that contains a TextBox,
            // like ContentWithDescription)
            var lastChild = MainStackPanel.Children[MainStackPanel.Children.Count - 1];

            IEnumerable<UIElement> controls;

            if (lastChild is Panel panel)
                controls = panel.Children.Cast<UIElement>();
            else
                controls = new[] { lastChild };


            // We check if the "Sender" (the TextBox that its text changes)
            // is the last TextBox, if yes, we add a new one (AddChild())
            if (controls.Contains(sender) || controls.Any(x => 
            {
           return x is ContentWithDescription content && content.Content == sender; 
        }))
            {
                AddChild();
            }
        }

        private static void OnInitialTextBoxesCountPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as MultiTextBoxes;
            control.MainStackPanel.Children.Clear();
            control.CreateInitialChildren();

        }
    }
}
