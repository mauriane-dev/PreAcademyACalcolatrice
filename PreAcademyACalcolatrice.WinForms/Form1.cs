using PreAcademyACalcolatrice.Core;

namespace PreAcademyACalcolatrice.WinForms
{
    public partial class Form1 : Form
    {
        double valueA;
        double valueB;
        string operation;
        Calculator c = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textValue.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textValue.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textValue.Text += btn9.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textValue.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textValue.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textValue.Text += btn6.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textValue.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textValue.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textValue.Text += btn3.Text;
        }

        private void btnVirgola_Click(object sender, EventArgs e)
        {
            textValue.Text += btnVirgola.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textValue.Text += btn0.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textValue.Clear();
        }

        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            textValue.Clear();
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            //SetOperation(textValue.Text, "somma");
            SetOperation(textValue.Text, btnSomma.Tag.ToString());
        }

        private void btnSottrai_Click(object sender, EventArgs e)
        {
            //SetOperation(textValue.Text, "sottrai");
            SetOperation(textValue.Text, btnSottrai.Tag.ToString());
        }

        private void btnMoltiplica_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, btnMoltiplica.Tag.ToString());
            //SetOperation(textValue.Text, "moltiplica");
        }

        private void btnDividi_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, btnDividi.Tag.ToString());
            //SetOperation(textValue.Text, "dividi");
        }

        private void btnUguale_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(textValue.Text) == true)
            //{
            //    valueB = 0;
            //}
            //else
            //{
            //    valueB = double.Parse(textValue.Text);
            //}
            valueB= string.IsNullOrEmpty(textValue.Text)? 0: double.Parse(textValue.Text);

            switch (operation)
            {
                case "somma":
                    textValue.Text= c.SommaNumeri(valueA, valueB).ToString();
                    break;
                case "sottrai":
                    textValue.Text = c.SottraiNumeri(valueA, valueB).ToString();
                    break;
                case "moltiplica":
                    textValue.Text = c.MoltiplicaNumeri(valueA, valueB).ToString();
                    break;
                case "dividi":
                    var risultato= c.DividiNumeri(valueA, valueB);
                    textValue.Text = (risultato==null) ? "Errore" : risultato.ToString();
                    break;
            }
        }
    }
}