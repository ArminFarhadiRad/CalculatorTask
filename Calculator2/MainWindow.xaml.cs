using System.Globalization;
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
        float number1=float.NaN;
        float number2;
        string oprator;
        float result=float.NaN;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (textResult.Text.Contains("+") || textResult.Text.Contains("-") || textResult.Text.Contains("*") || textResult.Text.Contains("/"))
            {
                textResult.Text = "";
                textResult.Text += button.Content.ToString();
                number2 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);

            }
            else
            {
                textResult.Text += button.Content.ToString();
                number2 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
            }
           

            
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            if (float.NaN.Equals(number1))
            {
                number1 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                EqualOprator(number1, number2);
            }
            oprator = "+";
            Button button = (Button)sender;
            textResult.Text += button.Content.ToString();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (float.NaN.Equals(number1))
            {
                number1 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                EqualOprator(number1, number2);
            }
            oprator = "-";
            Button button = (Button)sender;
            textResult.Text += button.Content.ToString();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (float.NaN.Equals(number1))
            {
                number1 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                EqualOprator(number1, number2);
            }
            oprator = "*";
            Button button = (Button)sender;
            textResult.Text += button.Content.ToString();
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            if (float.NaN.Equals(number1))
            {
                number1 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                EqualOprator(number1, number2);
            }
            oprator = "/";
            Button button = (Button)sender;
            textResult.Text += button.Content.ToString();
        }


        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            number2 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);

            textResult.Clear();
            TextBox2.Clear();

            EqualOprator(number1, number2);

            textResult.Text= string.Format("{0:N2}", result);


        }

        private void EqualOprator(float num1, float num2)
        {

            switch (oprator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        result = 0;
                    }
                    break;

            }

            if (textResult.Text == "0")
            {
                textResult.Clear();
            }
            TextBox2.Clear();
            TextBox2.Text = string.Format("{0:N2}", result);
            number1 = result;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textResult.Clear();
            TextBox2.Clear();
            result = float.NaN;
            number1= float.NaN;
            
        }

    }
}