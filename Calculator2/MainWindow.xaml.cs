using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int number1;
        int number2;
        string oprator;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            textResult.Text += button.Content.ToString();
            number2 = int.Parse(textResult.Text);
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            number1= int.Parse(textResult.Text);
            oprator = "+";
            textResult.Clear();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            number1 = int.Parse(textResult.Text);
            oprator = "-";
            textResult.Clear();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            number1 = int.Parse(textResult.Text);
            oprator = "*";
            textResult.Clear();
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            number1 = int.Parse(textResult.Text);
            oprator = "/";
            textResult.Clear();
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            number2 = int.Parse(textResult.Text);
            int result = 0;

            switch (oprator)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if(number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        result = 0;
                    }
                    break;

            }

            if(textResult.Text == "0")
            {
                textResult.Clear();
            }

            textResult.Text=result.ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textResult.Clear();
        }
    }
}