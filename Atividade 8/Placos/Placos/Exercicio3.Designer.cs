namespace Placos
{
    partial class frmExercicio3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Verifica = new System.Windows.Forms.Button();
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.lbl_DigitePalindromo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Verifica
            // 
            this.btn_Verifica.Location = new System.Drawing.Point(41, 88);
            this.btn_Verifica.Name = "btn_Verifica";
            this.btn_Verifica.Size = new System.Drawing.Size(75, 23);
            this.btn_Verifica.TabIndex = 0;
            this.btn_Verifica.Text = "VERIFICAR";
            this.btn_Verifica.UseVisualStyleBackColor = true;
            this.btn_Verifica.Click += new System.EventHandler(this.btn_Verifica_Click);
            // 
            // txt_Texto
            // 
            this.txt_Texto.Location = new System.Drawing.Point(41, 51);
            this.txt_Texto.MaxLength = 50;
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.Size = new System.Drawing.Size(511, 20);
            this.txt_Texto.TabIndex = 1;
            // 
            // lbl_DigitePalindromo
            // 
            this.lbl_DigitePalindromo.AutoSize = true;
            this.lbl_DigitePalindromo.Location = new System.Drawing.Point(38, 22);
            this.lbl_DigitePalindromo.Name = "lbl_DigitePalindromo";
            this.lbl_DigitePalindromo.Size = new System.Drawing.Size(108, 13);
            this.lbl_DigitePalindromo.TabIndex = 2;
            this.lbl_DigitePalindromo.Text = "Digite um Palíndromo";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_DigitePalindromo);
            this.Controls.Add(this.txt_Texto);
            this.Controls.Add(this.btn_Verifica);
            this.Name = "frmExercicio3";
            this.Text = "Exercicio3";
            this.Load += new System.EventHandler(this.Exercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Verifica;
        private System.Windows.Forms.TextBox txt_Texto;
        private System.Windows.Forms.Label lbl_DigitePalindromo;
    }
}