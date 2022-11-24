using System; //OK
using System.Collections.Generic; //OK
using System.Linq; //OK
using System.Text; //OK
using System.Text.RegularExpressions; //OK
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

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bt_mode.Content = "";
        }
        private int num1;
        private string calc = null;
        private int num2;
        public System.Windows.ResizeMode CanMinimize { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            bt_mode.Content = "";
        }

        private void TextBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }

        private void TextBox1_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }

        private void bt_0_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "0";
        }

        private void bt_1_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "1";
        }

        private void bt_2_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "2";
        }

        private void bt_3_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "3";
        }

        private void bt_4_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "4";
        }

        private void bt_5_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "5";
        }

        private void bt_6_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "6";
        }

        private void bt_7_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "7";
        }

        private void bt_8_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "8";
        }

        private void bt_9_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "9";
        }

        private void bt_dot_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("not working");
        }

        private void bt_equal_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text.Contains("1") || TextBox1.Text.Contains("2") || TextBox1.Text.Contains("3") || TextBox1.Text.Contains("4") || TextBox1.Text.Contains("5") || TextBox1.Text.Contains("6") || TextBox1.Text.Contains("7") || TextBox1.Text.Contains("8") || TextBox1.Text.Contains("9"))
            {
                bt_mode.Content = "";
                num2 = int.Parse(TextBox1.Text);
                if (calc == "+")
                {
                    int sum = num1 + num2;
                    TextBox1.Text = sum.ToString();
                }
                else if (calc == "-")
                {
                    int sum = num2 - num1;
                    TextBox1.Text = sum.ToString();
                }
                else if (calc == "*")
                {
                    int sum = num1 * num2;
                    TextBox1.Text = sum.ToString();
                }
                else if (calc == "/")
                {
                    int sum = num1 / num2;
                    TextBox1.Text = sum.ToString();
                }
            }
        }

        private void bt_minus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text.Contains("1") || TextBox1.Text.Contains("2") || TextBox1.Text.Contains("3") || TextBox1.Text.Contains("4") || TextBox1.Text.Contains("5") || TextBox1.Text.Contains("6") || TextBox1.Text.Contains("7") || TextBox1.Text.Contains("8") || TextBox1.Text.Contains("9"))
            {
                bt_mode.Content = "－";
                num1 = int.Parse(TextBox1.Text);
                calc = "-";
                TextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("数字を入力してください");
            }
        }

        private void bt_plus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text.Contains("1") || TextBox1.Text.Contains("2") || TextBox1.Text.Contains("3") || TextBox1.Text.Contains("4") || TextBox1.Text.Contains("5") || TextBox1.Text.Contains("6") || TextBox1.Text.Contains("7") || TextBox1.Text.Contains("8") || TextBox1.Text.Contains("9"))
            {
                bt_mode.Content = "＋";
                num1 = int.Parse(TextBox1.Text);
                calc = "+";
                TextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("数字を入力してください");
            }
        }

        private void bt_hang_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text.Contains("1") || TextBox1.Text.Contains("2") || TextBox1.Text.Contains("3") || TextBox1.Text.Contains("4") || TextBox1.Text.Contains("5") || TextBox1.Text.Contains("6") || TextBox1.Text.Contains("7") || TextBox1.Text.Contains("8") || TextBox1.Text.Contains("9"))
            {
                bt_mode.Content = "×";
                num1 = int.Parse(TextBox1.Text);
                calc = "*";
                TextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("数字を入力してください");
            }
        }

        private void bt_divide_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text.Contains("1") || TextBox1.Text.Contains("2") || TextBox1.Text.Contains("3") || TextBox1.Text.Contains("4") || TextBox1.Text.Contains("5") || TextBox1.Text.Contains("6") || TextBox1.Text.Contains("7") || TextBox1.Text.Contains("8") || TextBox1.Text.Contains("9"))
            {
                bt_mode.Content = "÷";
                num1 = int.Parse(TextBox1.Text);
                calc = "/";
                TextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("数字を入力してください");
            }
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
