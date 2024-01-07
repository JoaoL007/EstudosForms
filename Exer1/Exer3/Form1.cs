using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Largura = int.Parse(txtLarg.Text);
            double Comprimento = int.Parse(txtComp.Text);

            double Resultado = Largura * Comprimento;

            txtResultado.Text = Resultado.ToString();
        }
    }
}
