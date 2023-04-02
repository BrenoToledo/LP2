namespace Calculo_IMC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMenssage = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mtxtPeso = new System.Windows.Forms.MaskedTextBox();
            this.mtxtAltura = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PESO ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ALTURA";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(44, 74);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(184, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMenssage
            // 
            this.lblMenssage.AutoSize = true;
            this.lblMenssage.ForeColor = System.Drawing.Color.Red;
            this.lblMenssage.Location = new System.Drawing.Point(41, 145);
            this.lblMenssage.Name = "lblMenssage";
            this.lblMenssage.Size = new System.Drawing.Size(70, 13);
            this.lblMenssage.TabIndex = 5;
            this.lblMenssage.Text = "Bem Vindo(a)";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(140, 103);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(88, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(44, 103);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR ";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // mtxtPeso
            // 
            this.mtxtPeso.Location = new System.Drawing.Point(97, 23);
            this.mtxtPeso.Mask = "990.00";
            this.mtxtPeso.Name = "mtxtPeso";
            this.mtxtPeso.Size = new System.Drawing.Size(131, 20);
            this.mtxtPeso.TabIndex = 8;
            this.mtxtPeso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtPeso_MaskInputRejected);
            this.mtxtPeso.Validated += new System.EventHandler(this.mtxtPeso_Validated);
            // 
            // mtxtAltura
            // 
            this.mtxtAltura.Location = new System.Drawing.Point(97, 48);
            this.mtxtAltura.Mask = "0.00";
            this.mtxtAltura.Name = "mtxtAltura";
            this.mtxtAltura.Size = new System.Drawing.Size(131, 20);
            this.mtxtAltura.TabIndex = 9;
            this.mtxtAltura.Validated += new System.EventHandler(this.mtxtAltura_Validated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 204);
            this.Controls.Add(this.mtxtAltura);
            this.Controls.Add(this.mtxtPeso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblMenssage);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMenssage;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mtxtPeso;
        private System.Windows.Forms.MaskedTextBox mtxtAltura;
    }
}

