using PreAcademyACalcolatrice.Core;
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

namespace PreAcademyACalcolatrice.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double valueA;
        double valueB;
        string operation;
        Calculator c = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            textValue.Clear();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn7.Content;
        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn8.Content;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn9.Content;
        }

        private void btnVirgola_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btnVirgola.Content;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn0.Content;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn3.Content;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn2.Content;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn1.Content;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn4.Content;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn5.Content;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn6.Content;
        }

        private void btnSomma_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, btnSomma.Tag.ToString());
        }

        private void SetOperation(string text, string? operationToDo)
        {
            valueA = double.Parse(text);
            operation = operationToDo;
            textValue.Clear();
        }

        private void btnMoltiplica_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, btnMoltiplica.Tag.ToString());
        }

        private void btnDividi_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, btnDividi.Tag.ToString());
        }

        private void btnSottrai_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, btnSottrai.Tag.ToString());
        }

        private void btnUguale_Click(object sender, RoutedEventArgs e)
        {
            valueB = string.IsNullOrEmpty(textValue.Text) ? 0 : double.Parse(textValue.Text); //operatore ternario
            switch (operation)
            {
                case "somma":
                    textValue.Text = c.SommaNumeri(valueA, valueB).ToString();
                    break;
                case "sottrai":
                    textValue.Text = c.SottraiNumeri(valueA, valueB).ToString();
                    break;
                case "moltiplica":
                    textValue.Text = c.MoltiplicaNumeri(valueA, valueB).ToString();
                    break;
                case "dividi":
                    var risultato = c.DividiNumeri(valueA, valueB);
                    textValue.Text = (risultato == null) ? "Errore" : risultato.ToString();
                    break;
            }
        }
    }
}
