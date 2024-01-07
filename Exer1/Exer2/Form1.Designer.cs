namespace Exer2
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
            this.lblKmsPercorridos = new System.Windows.Forms.Label();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.txtConsumoR = new System.Windows.Forms.TextBox();
            this.lblConsumoRegistrado = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.txtC100 = new System.Windows.Forms.TextBox();
            this.lblConsumo100 = new System.Windows.Forms.Label();
            this.txtValorGasto = new System.Windows.Forms.TextBox();
            this.lblValorGasto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKmsPercorridos
            // 
            this.lblKmsPercorridos.AutoSize = true;
            this.lblKmsPercorridos.Location = new System.Drawing.Point(12, 15);
            this.lblKmsPercorridos.Name = "lblKmsPercorridos";
            this.lblKmsPercorridos.Size = new System.Drawing.Size(82, 13);
            this.lblKmsPercorridos.TabIndex = 0;
            this.lblKmsPercorridos.Text = "Kms percorridos";
            // 
            // txtKms
            // 
            this.txtKms.Location = new System.Drawing.Point(218, 12);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(100, 20);
            this.txtKms.TabIndex = 1;
            // 
            // txtConsumoR
            // 
            this.txtConsumoR.Location = new System.Drawing.Point(218, 38);
            this.txtConsumoR.Name = "txtConsumoR";
            this.txtConsumoR.Size = new System.Drawing.Size(100, 20);
            this.txtConsumoR.TabIndex = 3;
            // 
            // lblConsumoRegistrado
            // 
            this.lblConsumoRegistrado.AutoSize = true;
            this.lblConsumoRegistrado.Location = new System.Drawing.Point(12, 41);
            this.lblConsumoRegistrado.Name = "lblConsumoRegistrado";
            this.lblConsumoRegistrado.Size = new System.Drawing.Size(105, 13);
            this.lblConsumoRegistrado.TabIndex = 2;
            this.lblConsumoRegistrado.Text = "Consumo Registrado";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(218, 64);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 5;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 67);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(95, 13);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço Compustivel";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(15, 90);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(303, 23);
            this.BtnCalcular.TabIndex = 9;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtC100
            // 
            this.txtC100.Location = new System.Drawing.Point(218, 131);
            this.txtC100.Name = "txtC100";
            this.txtC100.Size = new System.Drawing.Size(100, 20);
            this.txtC100.TabIndex = 11;
            // 
            // lblConsumo100
            // 
            this.lblConsumo100.AutoSize = true;
            this.lblConsumo100.Location = new System.Drawing.Point(12, 134);
            this.lblConsumo100.Name = "lblConsumo100";
            this.lblConsumo100.Size = new System.Drawing.Size(92, 13);
            this.lblConsumo100.TabIndex = 10;
            this.lblConsumo100.Text = "Consumo aos 100";
            // 
            // txtValorGasto
            // 
            this.txtValorGasto.Location = new System.Drawing.Point(218, 163);
            this.txtValorGasto.Name = "txtValorGasto";
            this.txtValorGasto.Size = new System.Drawing.Size(100, 20);
            this.txtValorGasto.TabIndex = 13;
            // 
            // lblValorGasto
            // 
            this.lblValorGasto.AutoSize = true;
            this.lblValorGasto.Location = new System.Drawing.Point(12, 166);
            this.lblValorGasto.Name = "lblValorGasto";
            this.lblValorGasto.Size = new System.Drawing.Size(62, 13);
            this.lblValorGasto.TabIndex = 12;
            this.lblValorGasto.Text = "Valor Gasto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 190);
            this.Controls.Add(this.txtValorGasto);
            this.Controls.Add(this.lblValorGasto);
            this.Controls.Add(this.txtC100);
            this.Controls.Add(this.lblConsumo100);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtConsumoR);
            this.Controls.Add(this.lblConsumoRegistrado);
            this.Controls.Add(this.txtKms);
            this.Controls.Add(this.lblKmsPercorridos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKmsPercorridos;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.TextBox txtConsumoR;
        private System.Windows.Forms.Label lblConsumoRegistrado;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox txtC100;
        private System.Windows.Forms.Label lblConsumo100;
        private System.Windows.Forms.TextBox txtValorGasto;
        private System.Windows.Forms.Label lblValorGasto;
    }
}

