using System;
using System.Windows.Forms;

namespace Exer1
{
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Salario = double.Parse(TxtSalario.Text);
            double SalarioISSFinal = Salario * 0.15;

            TxtIRS.Text = SalarioISSFinal.ToString();

            double SalarioSSFinal = Salario * 0.12;

            TxtSS.Text = SalarioSSFinal.ToString();

            double SalarioLiquido = Salario - SalarioISSFinal - SalarioSSFinal ;

            TxtSL.Text = SalarioLiquido.ToString();
        }

        private void TxtSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
