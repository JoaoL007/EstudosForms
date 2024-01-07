namespace Exer1
{
    partial class frmSalario
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
            this.TxtIRS = new System.Windows.Forms.TextBox();
            this.TxtSS = new System.Windows.Forms.TextBox();
            this.TxtSL = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblIRS = new System.Windows.Forms.Label();
            this.lblSS = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.lblSL = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtIRS
            // 
            this.TxtIRS.Location = new System.Drawing.Point(140, 110);
            this.TxtIRS.Name = "TxtIRS";
            this.TxtIRS.Size = new System.Drawing.Size(100, 20);
            this.TxtIRS.TabIndex = 1;
            // 
            // TxtSS
            // 
            this.TxtSS.Location = new System.Drawing.Point(140, 136);
            this.TxtSS.Name = "TxtSS";
            this.TxtSS.Size = new System.Drawing.Size(100, 20);
            this.TxtSS.TabIndex = 2;
            // 
            // TxtSL
            // 
            this.TxtSL.Location = new System.Drawing.Point(140, 162);
            this.TxtSL.Name = "TxtSL";
            this.TxtSL.Size = new System.Drawing.Size(100, 20);
            this.TxtSL.TabIndex = 3;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 19);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario";
            // 
            // lblIRS
            // 
            this.lblIRS.AutoSize = true;
            this.lblIRS.Location = new System.Drawing.Point(12, 117);
            this.lblIRS.Name = "lblIRS";
            this.lblIRS.Size = new System.Drawing.Size(25, 13);
            this.lblIRS.TabIndex = 5;
            this.lblIRS.Text = "IRS";
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.Location = new System.Drawing.Point(12, 143);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(61, 13);
            this.lblSS.TabIndex = 6;
            this.lblSS.Text = "Seg. Social";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(15, 62);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(225, 23);
            this.BtnCalcular.TabIndex = 8;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(12, 169);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(76, 13);
            this.lblSL.TabIndex = 9;
            this.lblSL.Text = "Salario Liquido";
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(140, 12);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(100, 20);
            this.TxtSalario.TabIndex = 10;
            this.TxtSalario.TextChanged += new System.EventHandler(this.TxtSalario_TextChanged);
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 196);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.lblIRS);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.TxtSL);
            this.Controls.Add(this.TxtSS);
            this.Controls.Add(this.TxtIRS);
            this.Name = "frmSalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtIRS;
        private System.Windows.Forms.TextBox TxtSS;
        private System.Windows.Forms.TextBox TxtSL;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblIRS;
        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox TxtSalario;
    }
}

