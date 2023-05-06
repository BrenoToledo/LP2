namespace PMenu
{
    partial class FrmExercicio4
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnIsNumber = new System.Windows.Forms.Button();
            this.btnFirstSpace = new System.Windows.Forms.Button();
            this.btnIsLetter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(420, 210);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnIsNumber
            // 
            this.btnIsNumber.Location = new System.Drawing.Point(35, 291);
            this.btnIsNumber.Name = "btnIsNumber";
            this.btnIsNumber.Size = new System.Drawing.Size(186, 121);
            this.btnIsNumber.TabIndex = 1;
            this.btnIsNumber.Text = "Count Numbers";
            this.btnIsNumber.UseVisualStyleBackColor = true;
            this.btnIsNumber.Click += new System.EventHandler(this.btnIsNumber_Click);
            // 
            // btnFirstSpace
            // 
            this.btnFirstSpace.Location = new System.Drawing.Point(269, 291);
            this.btnFirstSpace.Name = "btnFirstSpace";
            this.btnFirstSpace.Size = new System.Drawing.Size(186, 121);
            this.btnFirstSpace.TabIndex = 2;
            this.btnFirstSpace.Text = "Primeiro Espaço";
            this.btnFirstSpace.UseVisualStyleBackColor = true;
            this.btnFirstSpace.Click += new System.EventHandler(this.btnFirstSpace_Click);
            // 
            // btnIsLetter
            // 
            this.btnIsLetter.Location = new System.Drawing.Point(498, 291);
            this.btnIsLetter.Name = "btnIsLetter";
            this.btnIsLetter.Size = new System.Drawing.Size(186, 121);
            this.btnIsLetter.TabIndex = 3;
            this.btnIsLetter.Text = "Count Letter";
            this.btnIsLetter.UseVisualStyleBackColor = true;
            this.btnIsLetter.Click += new System.EventHandler(this.btnIsLetter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 96);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIsLetter);
            this.Controls.Add(this.btnFirstSpace);
            this.Controls.Add(this.btnIsNumber);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmExercicio4";
            this.Text = "FrmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnIsNumber;
        private System.Windows.Forms.Button btnFirstSpace;
        private System.Windows.Forms.Button btnIsLetter;
        private System.Windows.Forms.Button button1;
    }
}