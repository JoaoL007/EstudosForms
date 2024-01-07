using System;
using System.Windows.Forms;

namespace Exer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double KmsPercorridos = int.Parse(txtKms.Text);
            double ConsumoRegistrado = int.Parse(txtConsumoR.Text);
            double PreçoDoCombustivel = int.Parse(txtPreco.Text);

            double Consumo100 = ConsumoRegistrado / KmsPercorridos * 100;
            double ValorGasto = (KmsPercorridos / 100) * ConsumoRegistrado * PreçoDoCombustivel;
            
            txtC100.Text = Consumo100.ToString();
            txtValorGasto.Text = ValorGasto.ToString();

        }

    }
}
