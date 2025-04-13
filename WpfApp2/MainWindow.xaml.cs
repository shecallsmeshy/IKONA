using System.Windows;

namespace WpfCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = num1 + num2;
                resultText.Text = result.ToString();
            }
            else
            {
                resultText.Text = "Invalid input";
            }
        }
        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = num1 - num2;
                resultText.Text = result.ToString();
            }
            else
            {
                resultText.Text = "Invalid input";
            }
        }
    }
}