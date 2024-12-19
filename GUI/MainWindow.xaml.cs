using System.Windows;

namespace GUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSubmitClick(object sender, RoutedEventArgs e)
        {
            string name = NameInput.Text; // Get the name input
            GreetingText.Text = $"Hello {name}!"; // Update the TextBlock
        }
    }
}