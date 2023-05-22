namespace Pmatriz
{
    partial class frm_Exercicio06
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
            this.btn_Executar = new System.Windows.Forms.Button();
            this.lbx_formulario = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Executar
            // 
            this.btn_Executar.Location = new System.Drawing.Point(127, 99);
            this.btn_Executar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(303, 197);
            this.btn_Executar.TabIndex = 0;
            this.btn_Executar.Text = "Adicionar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // lbx_formulario
            // 
            this.lbx_formulario.FormattingEnabled = true;
            this.lbx_formulario.ItemHeight = 16;
            this.lbx_formulario.Location = new System.Drawing.Point(527, 66);
            this.lbx_formulario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbx_formulario.Name = "lbx_formulario";
            this.lbx_formulario.Size = new System.Drawing.Size(464, 404);
            this.lbx_formulario.TabIndex = 1;
            // 
            // frm_Exercicio06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbx_formulario);
            this.Controls.Add(this.btn_Executar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Exercicio06";
            this.Text = "Exercicio 06";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.ListBox lbx_formulario;
    }
}