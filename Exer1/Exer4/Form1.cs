using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int VotosBrancos = int.Parse(txtVotosB.Text);
            int VotosNulos = int.Parse(txtVotosN.Text);
            int VotosValidos = int.Parse(txtVotosV.Text);
            int PopulaçãoMunicipio = int.Parse(txtPpMunicipio.Text);

            double percentualBranco = (double)VotosBrancos / PopulaçãoMunicipio * 100;
            double percentualNulo = (double)VotosNulos / PopulaçãoMunicipio * 100;
            double percentualValidos = (double)VotosValidos / PopulaçãoMunicipio * 100;

            txtPorcentB.Text = percentualBranco + "%";
            txtPorcentN.Text = percentualNulo + "%";
            txtPorcentV.Text = percentualValidos + "%";
        }

        private void lblPorcentoN_Click(object sender, EventArgs e)
        {

        }
    }
}
