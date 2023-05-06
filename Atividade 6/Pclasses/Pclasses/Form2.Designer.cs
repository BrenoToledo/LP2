namespace Pclasses
{
    partial class FrmMensalista
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
            this.txtBoxMatriculaMensalista = new System.Windows.Forms.TextBox();
            this.txtBoxNomeMensalista = new System.Windows.Forms.TextBox();
            this.txtBoxSalarioMensalista = new System.Windows.Forms.TextBox();
            this.mkdTxtBoxDataEntradaMensalista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnNaoMensalista = new System.Windows.Forms.RadioButton();
            this.rdBtnSimMensalista = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxMatriculaMensalista
            // 
            this.txtBoxMatriculaMensalista.Location = new System.Drawing.Point(268, 87);
            this.txtBoxMatriculaMensalista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxMatriculaMensalista.Name = "txtBoxMatriculaMensalista";
            this.txtBoxMatriculaMensalista.Size = new System.Drawing.Size(116, 20);
            this.txtBoxMatriculaMensalista.TabIndex = 0;
            // 
            // txtBoxNomeMensalista
            // 
            this.txtBoxNomeMensalista.Location = new System.Drawing.Point(268, 137);
            this.txtBoxNomeMensalista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxNomeMensalista.Name = "txtBoxNomeMensalista";
            this.txtBoxNomeMensalista.Size = new System.Drawing.Size(306, 20);
            this.txtBoxNomeMensalista.TabIndex = 1;
            // 
            // txtBoxSalarioMensalista
            // 
            this.txtBoxSalarioMensalista.Location = new System.Drawing.Point(268, 195);
            this.txtBoxSalarioMensalista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxSalarioMensalista.Name = "txtBoxSalarioMensalista";
            this.txtBoxSalarioMensalista.Size = new System.Drawing.Size(116, 20);
            this.txtBoxSalarioMensalista.TabIndex = 2;
            // 
            // mkdTxtBoxDataEntradaMensalista
            // 
            this.mkdTxtBoxDataEntradaMensalista.Location = new System.Drawing.Point(268, 252);
            this.mkdTxtBoxDataEntradaMensalista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mkdTxtBoxDataEntradaMensalista.Name = "mkdTxtBoxDataEntradaMensalista";
            this.mkdTxtBoxDataEntradaMensalista.Size = new System.Drawing.Size(116, 20);
            this.mkdTxtBoxDataEntradaMensalista.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salário Mensal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Entrada na Empresa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 312);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 72);
            this.button1.TabIndex = 8;
            this.button1.Text = "Instanciar Mensalista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 312);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 72);
            this.button2.TabIndex = 9;
            this.button2.Text = "Instanciar Mensalista passando parametros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rdBtnNaoMensalista);
            this.groupBox1.Controls.Add(this.rdBtnSimMensalista);
            this.groupBox1.Location = new System.Drawing.Point(651, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(233, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalha em Home Office";
            // 
            // rdBtnNaoMensalista
            // 
            this.rdBtnNaoMensalista.AllowDrop = true;
            this.rdBtnNaoMensalista.AutoSize = true;
            this.rdBtnNaoMensalista.Location = new System.Drawing.Point(17, 57);
            this.rdBtnNaoMensalista.Name = "rdBtnNaoMensalista";
            this.rdBtnNaoMensalista.Size = new System.Drawing.Size(51, 17);
            this.rdBtnNaoMensalista.TabIndex = 1;
            this.rdBtnNaoMensalista.TabStop = true;
            this.rdBtnNaoMensalista.Text = "NÃO";
            this.rdBtnNaoMensalista.UseVisualStyleBackColor = true;
            this.rdBtnNaoMensalista.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdBtnSimMensalista
            // 
            this.rdBtnSimMensalista.AutoSize = true;
            this.rdBtnSimMensalista.Checked = true;
            this.rdBtnSimMensalista.Location = new System.Drawing.Point(17, 34);
            this.rdBtnSimMensalista.Name = "rdBtnSimMensalista";
            this.rdBtnSimMensalista.Size = new System.Drawing.Size(47, 17);
            this.rdBtnSimMensalista.TabIndex = 0;
            this.rdBtnSimMensalista.TabStop = true;
            this.rdBtnSimMensalista.Text = "SIM";
            this.rdBtnSimMensalista.UseVisualStyleBackColor = true;
            // 
            // FrmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mkdTxtBoxDataEntradaMensalista);
            this.Controls.Add(this.txtBoxSalarioMensalista);
            this.Controls.Add(this.txtBoxNomeMensalista);
            this.Controls.Add(this.txtBoxMatriculaMensalista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMensalista";
            this.Text = "FormMensalista";
            this.Load += new System.EventHandler(this.FrmMensalista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMatriculaMensalista;
        private System.Windows.Forms.TextBox txtBoxNomeMensalista;
        private System.Windows.Forms.TextBox txtBoxSalarioMensalista;
        private System.Windows.Forms.TextBox mkdTxtBoxDataEntradaMensalista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnNaoMensalista;
        private System.Windows.Forms.RadioButton rdBtnSimMensalista;
    }
}