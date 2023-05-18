namespace Placos
{
    partial class frmExercicio1
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
            this.btnBranco = new System.Windows.Forms.Button();
            this.rchTxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnRepetidos = new System.Windows.Forms.Button();
            this.btnContR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(64, 330);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(164, 71);
            this.btnBranco.TabIndex = 0;
            this.btnBranco.Text = "ESPAÇOS EM BRANCO";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.button1_Click);
            // 
            // rchTxtFrase
            // 
            this.rchTxtFrase.Location = new System.Drawing.Point(64, 65);
            this.rchTxtFrase.MaxLength = 100;
            this.rchTxtFrase.Name = "rchTxtFrase";
            this.rchTxtFrase.Size = new System.Drawing.Size(670, 215);
            this.rchTxtFrase.TabIndex = 1;
            this.rchTxtFrase.Text = "";
            this.rchTxtFrase.TextChanged += new System.EventHandler(this.rchTxtFrase_TextChanged);
            // 
            // btnRepetidos
            // 
            this.btnRepetidos.Location = new System.Drawing.Point(309, 330);
            this.btnRepetidos.Name = "btnRepetidos";
            this.btnRepetidos.Size = new System.Drawing.Size(164, 71);
            this.btnRepetidos.TabIndex = 2;
            this.btnRepetidos.Text = "REPETIDOS";
            this.btnRepetidos.UseVisualStyleBackColor = true;
            this.btnRepetidos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnContR
            // 
            this.btnContR.Location = new System.Drawing.Point(570, 330);
            this.btnContR.Name = "btnContR";
            this.btnContR.Size = new System.Drawing.Size(164, 71);
            this.btnContR.TabIndex = 3;
            this.btnContR.Text = "CORTAR OS R";
            this.btnContR.UseVisualStyleBackColor = true;
            this.btnContR.Click += new System.EventHandler(this.btnContR_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContR);
            this.Controls.Add(this.btnRepetidos);
            this.Controls.Add(this.rchTxtFrase);
            this.Controls.Add(this.btnBranco);
            this.Name = "frmExercicio1";
            this.Text = "Exercício 01 ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.RichTextBox rchTxtFrase;
        private System.Windows.Forms.Button btnRepetidos;
        private System.Windows.Forms.Button btnContR;
    }
}