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

namespace _2_CalculadoraBasica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int solucion = 0;
            int i;
            if (int.TryParse(operador1TextBox.Text, out i) && int.TryParse(operador2TextBox.Text, out i))
            {
                switch (operadorTextBox.Text)
                {
                    case "+":
                        solucion = int.Parse(operador1TextBox.Text) + int.Parse(operador2TextBox.Text);
                        break;
                    case "-":
                        solucion = int.Parse(operador1TextBox.Text) - int.Parse(operador2TextBox.Text);
                        break;
                    case "*":
                        solucion = int.Parse(operador1TextBox.Text) * int.Parse(operador2TextBox.Text);
                        break;
                    case "/":
                        solucion = int.Parse(operador1TextBox.Text) / int.Parse(operador2TextBox.Text);
                        break;
                    default:
                        break;
                }
                resultadoTextBox.Text = solucion.ToString();
            }
            else
            {
                MessageBox.Show("Se ha producido un error revise los operadores");
            }
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operador1TextBox.Text = "";
            operador2TextBox.Text = "";
            operadorTextBox.Text = "";
            resultadoTextBox.Text = "";
        }

        private void OperadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (operadorTextBox.Text == "+" || operadorTextBox.Text == "-" || operadorTextBox.Text == "*" | operadorTextBox.Text == "/")
            {
                calcularButton.IsEnabled = true;
            }
            else
            {
                calcularButton.IsEnabled = false;
            }
        }
    }
}
