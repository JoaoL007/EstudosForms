namespace Exer4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBrancos = new System.Windows.Forms.Label();
            this.lblNulos = new System.Windows.Forms.Label();
            this.lblValidos = new System.Windows.Forms.Label();
            this.txtVotosN = new System.Windows.Forms.TextBox();
            this.txtVotosB = new System.Windows.Forms.TextBox();
            this.txtPpMunicipio = new System.Windows.Forms.TextBox();
            this.txtVotosV = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPorcentoB = new System.Windows.Forms.Label();
            this.lblPorcentoN = new System.Windows.Forms.Label();
            this.lblPorcentoV = new System.Windows.Forms.Label();
            this.txtPorcentN = new System.Windows.Forms.TextBox();
            this.txtPorcentB = new System.Windows.Forms.TextBox();
            this.txtPorcentV = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBrancos
            // 
            this.lblBrancos.AutoSize = true;
            this.lblBrancos.Location = new System.Drawing.Point(12, 47);
            this.lblBrancos.Name = "lblBrancos";
            this.lblBrancos.Size = new System.Drawing.Size(76, 13);
            this.lblBrancos.TabIndex = 0;
            this.lblBrancos.Text = "Votos Brancos";
            // 
            // lblNulos
            // 
            this.lblNulos.AutoSize = true;
            this.lblNulos.Location = new System.Drawing.Point(12, 79);
            this.lblNulos.Name = "lblNulos";
            this.lblNulos.Size = new System.Drawing.Size(64, 13);
            this.lblNulos.TabIndex = 1;
            this.lblNulos.Text = "Votos Nulos";
            // 
            // lblValidos
            // 
            this.lblValidos.AutoSize = true;
            this.lblValidos.Location = new System.Drawing.Point(12, 114);
            this.lblValidos.Name = "lblValidos";
            this.lblValidos.Size = new System.Drawing.Size(71, 13);
            this.lblValidos.TabIndex = 2;
            this.lblValidos.Text = "Votos Validos";
            // 
            // txtVotosN
            // 
            this.txtVotosN.Location = new System.Drawing.Point(94, 73);
            this.txtVotosN.Name = "txtVotosN";
            this.txtVotosN.Size = new System.Drawing.Size(100, 20);
            this.txtVotosN.TabIndex = 7;
            // 
            // txtVotosB
            // 
            this.txtVotosB.Location = new System.Drawing.Point(94, 44);
            this.txtVotosB.Name = "txtVotosB";
            this.txtVotosB.Size = new System.Drawing.Size(100, 20);
            this.txtVotosB.TabIndex = 6;
            // 
            // txtPpMunicipio
            // 
            this.txtPpMunicipio.Location = new System.Drawing.Point(72, 151);
            this.txtPpMunicipio.Name = "txtPpMunicipio";
            this.txtPpMunicipio.Size = new System.Drawing.Size(100, 20);
            this.txtPpMunicipio.TabIndex = 9;
            // 
            // txtVotosV
            // 
            this.txtVotosV.Location = new System.Drawing.Point(94, 111);
            this.txtVotosV.Name = "txtVotosV";
            this.txtVotosV.Size = new System.Drawing.Size(100, 20);
            this.txtVotosV.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(203, 193);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPorcentoB
            // 
            this.lblPorcentoB.AutoSize = true;
            this.lblPorcentoB.Location = new System.Drawing.Point(12, 139);
            this.lblPorcentoB.Name = "lblPorcentoB";
            this.lblPorcentoB.Size = new System.Drawing.Size(54, 13);
            this.lblPorcentoB.TabIndex = 11;
            this.lblPorcentoB.Text = "%Brancos";
            // 
            // lblPorcentoN
            // 
            this.lblPorcentoN.AutoSize = true;
            this.lblPorcentoN.Location = new System.Drawing.Point(12, 168);
            this.lblPorcentoN.Name = "lblPorcentoN";
            this.lblPorcentoN.Size = new System.Drawing.Size(42, 13);
            this.lblPorcentoN.TabIndex = 12;
            this.lblPorcentoN.Text = "%Nulos";
            this.lblPorcentoN.Click += new System.EventHandler(this.lblPorcentoN_Click);
            // 
            // lblPorcentoV
            // 
            this.lblPorcentoV.AutoSize = true;
            this.lblPorcentoV.Location = new System.Drawing.Point(12, 194);
            this.lblPorcentoV.Name = "lblPorcentoV";
            this.lblPorcentoV.Size = new System.Drawing.Size(49, 13);
            this.lblPorcentoV.TabIndex = 13;
            this.lblPorcentoV.Text = "%Validos";
            // 
            // txtPorcentN
            // 
            this.txtPorcentN.Location = new System.Drawing.Point(72, 165);
            this.txtPorcentN.Name = "txtPorcentN";
            this.txtPorcentN.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentN.TabIndex = 15;
            // 
            // txtPorcentB
            // 
            this.txtPorcentB.Location = new System.Drawing.Point(72, 136);
            this.txtPorcentB.Name = "txtPorcentB";
            this.txtPorcentB.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentB.TabIndex = 14;
            // 
            // txtPorcentV
            // 
            this.txtPorcentV.Location = new System.Drawing.Point(72, 191);
            this.txtPorcentV.Name = "txtPorcentV";
            this.txtPorcentV.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentV.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(12, 9);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(124, 13);
            this.lblMunicipio.TabIndex = 18;
            this.lblMunicipio.Text = "Populaçao do Municipio ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 228);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.txtPorcentV);
            this.Controls.Add(this.txtPorcentN);
            this.Controls.Add(this.txtPorcentB);
            this.Controls.Add(this.lblPorcentoV);
            this.Controls.Add(this.lblPorcentoN);
            this.Controls.Add(this.lblPorcentoB);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPpMunicipio);
            this.Controls.Add(this.txtVotosV);
            this.Controls.Add(this.txtVotosN);
            this.Controls.Add(this.txtVotosB);
            this.Controls.Add(this.lblValidos);
            this.Controls.Add(this.lblNulos);
            this.Controls.Add(this.lblBrancos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrancos;
        private System.Windows.Forms.Label lblNulos;
        private System.Windows.Forms.Label lblValidos;
        private System.Windows.Forms.TextBox txtVotosN;
        private System.Windows.Forms.TextBox txtVotosB;
        private System.Windows.Forms.TextBox txtPpMunicipio;
        private System.Windows.Forms.TextBox txtVotosV;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPorcentoB;
        private System.Windows.Forms.Label lblPorcentoN;
        private System.Windows.Forms.Label lblPorcentoV;
        private System.Windows.Forms.TextBox txtPorcentN;
        private System.Windows.Forms.TextBox txtPorcentB;
        private System.Windows.Forms.TextBox txtPorcentV;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblMunicipio;
    }
}

