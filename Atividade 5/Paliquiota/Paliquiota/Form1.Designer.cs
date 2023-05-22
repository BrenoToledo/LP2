namespace Paliquiota
{
    partial class frm_CalculaAliquota
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
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.tbox_Nome = new System.Windows.Forms.TextBox();
            this.mtbox_SalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.nupd_NumeroFilhos = new System.Windows.Forms.NumericUpDown();
            this.lbl_SalarioBruto = new System.Windows.Forms.Label();
            this.lbl_NumeroDeFilhos = new System.Windows.Forms.Label();
            this.btn_CalculaDesconto = new System.Windows.Forms.Button();
            this.lbl_Mensagem = new System.Windows.Forms.Label();
            this.tbox_AliquotaINSS = new System.Windows.Forms.TextBox();
            this.lbl_AliquotaINSS = new System.Windows.Forms.Label();
            this.tbox_AliquotaIRPF = new System.Windows.Forms.TextBox();
            this.lbl_AliquotaIRPF = new System.Windows.Forms.Label();
            this.tbox_SalarioFamilia = new System.Windows.Forms.TextBox();
            this.lbl_SalarioFamilia = new System.Windows.Forms.Label();
            this.tbox_SalarioLiquido = new System.Windows.Forms.TextBox();
            this.lbl_SalarioLiquido = new System.Windows.Forms.Label();
            this.tbox_DescontoINSS = new System.Windows.Forms.TextBox();
            this.lbl_DescontoINSS = new System.Windows.Forms.Label();
            this.tbox_DescontoIRPF = new System.Windows.Forms.TextBox();
            this.lbl_DescontoIRPF = new System.Windows.Forms.Label();
            this.grBox_Sexo = new System.Windows.Forms.GroupBox();
            this.grBox_EstaoCivil = new System.Windows.Forms.GroupBox();
            this.cbox_Masculino = new System.Windows.Forms.CheckBox();
            this.cbox_Feminino = new System.Windows.Forms.CheckBox();
            this.cbox_IsCasado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_NumeroFilhos)).BeginInit();
            this.grBox_Sexo.SuspendLayout();
            this.grBox_EstaoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NomeFuncionario
            // 
            this.lbl_NomeFuncionario.AutoSize = true;
            this.lbl_NomeFuncionario.Location = new System.Drawing.Point(31, 46);
            this.lbl_NomeFuncionario.Name = "lbl_NomeFuncionario";
            this.lbl_NomeFuncionario.Size = new System.Drawing.Size(93, 13);
            this.lbl_NomeFuncionario.TabIndex = 0;
            this.lbl_NomeFuncionario.Text = "Nome Funcionário";
            // 
            // tbox_Nome
            // 
            this.tbox_Nome.Location = new System.Drawing.Point(130, 43);
            this.tbox_Nome.Name = "tbox_Nome";
            this.tbox_Nome.Size = new System.Drawing.Size(100, 20);
            this.tbox_Nome.TabIndex = 1;
            this.tbox_Nome.TextChanged += new System.EventHandler(this.tbox_Nome_TextChanged);
            // 
            // mtbox_SalarioBruto
            // 
            this.mtbox_SalarioBruto.Location = new System.Drawing.Point(130, 69);
            this.mtbox_SalarioBruto.Mask = "99999.00";
            this.mtbox_SalarioBruto.Name = "mtbox_SalarioBruto";
            this.mtbox_SalarioBruto.Size = new System.Drawing.Size(100, 20);
            this.mtbox_SalarioBruto.TabIndex = 2;
            this.mtbox_SalarioBruto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbox_SalarioBruto_MaskInputRejected);
            // 
            // nupd_NumeroFilhos
            // 
            this.nupd_NumeroFilhos.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.nupd_NumeroFilhos.Location = new System.Drawing.Point(130, 95);
            this.nupd_NumeroFilhos.Name = "nupd_NumeroFilhos";
            this.nupd_NumeroFilhos.Size = new System.Drawing.Size(120, 20);
            this.nupd_NumeroFilhos.TabIndex = 3;
            // 
            // lbl_SalarioBruto
            // 
            this.lbl_SalarioBruto.AutoSize = true;
            this.lbl_SalarioBruto.Location = new System.Drawing.Point(31, 72);
            this.lbl_SalarioBruto.Name = "lbl_SalarioBruto";
            this.lbl_SalarioBruto.Size = new System.Drawing.Size(67, 13);
            this.lbl_SalarioBruto.TabIndex = 4;
            this.lbl_SalarioBruto.Text = "Salário Bruto";
            // 
            // lbl_NumeroDeFilhos
            // 
            this.lbl_NumeroDeFilhos.AutoSize = true;
            this.lbl_NumeroDeFilhos.Location = new System.Drawing.Point(31, 97);
            this.lbl_NumeroDeFilhos.Name = "lbl_NumeroDeFilhos";
            this.lbl_NumeroDeFilhos.Size = new System.Drawing.Size(86, 13);
            this.lbl_NumeroDeFilhos.TabIndex = 5;
            this.lbl_NumeroDeFilhos.Text = "Número de filhos";
            // 
            // btn_CalculaDesconto
            // 
            this.btn_CalculaDesconto.Location = new System.Drawing.Point(34, 142);
            this.btn_CalculaDesconto.Name = "btn_CalculaDesconto";
            this.btn_CalculaDesconto.Size = new System.Drawing.Size(119, 23);
            this.btn_CalculaDesconto.TabIndex = 6;
            this.btn_CalculaDesconto.Text = "Verifica Desconto";
            this.btn_CalculaDesconto.UseVisualStyleBackColor = true;
            this.btn_CalculaDesconto.Click += new System.EventHandler(this.btn_CalculaDesconto_Click);
            // 
            // lbl_Mensagem
            // 
            this.lbl_Mensagem.AutoSize = true;
            this.lbl_Mensagem.Location = new System.Drawing.Point(31, 184);
            this.lbl_Mensagem.Name = "lbl_Mensagem";
            this.lbl_Mensagem.Size = new System.Drawing.Size(59, 13);
            this.lbl_Mensagem.TabIndex = 7;
            this.lbl_Mensagem.Text = "Mensagem";
            this.lbl_Mensagem.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbox_AliquotaINSS
            // 
            this.tbox_AliquotaINSS.Location = new System.Drawing.Point(130, 236);
            this.tbox_AliquotaINSS.Name = "tbox_AliquotaINSS";
            this.tbox_AliquotaINSS.Size = new System.Drawing.Size(100, 20);
            this.tbox_AliquotaINSS.TabIndex = 9;
            // 
            // lbl_AliquotaINSS
            // 
            this.lbl_AliquotaINSS.AutoSize = true;
            this.lbl_AliquotaINSS.Location = new System.Drawing.Point(31, 239);
            this.lbl_AliquotaINSS.Name = "lbl_AliquotaINSS";
            this.lbl_AliquotaINSS.Size = new System.Drawing.Size(73, 13);
            this.lbl_AliquotaINSS.TabIndex = 8;
            this.lbl_AliquotaINSS.Text = "Aliquota INSS";
            // 
            // tbox_AliquotaIRPF
            // 
            this.tbox_AliquotaIRPF.Location = new System.Drawing.Point(130, 266);
            this.tbox_AliquotaIRPF.Name = "tbox_AliquotaIRPF";
            this.tbox_AliquotaIRPF.Size = new System.Drawing.Size(100, 20);
            this.tbox_AliquotaIRPF.TabIndex = 11;
            // 
            // lbl_AliquotaIRPF
            // 
            this.lbl_AliquotaIRPF.AutoSize = true;
            this.lbl_AliquotaIRPF.Location = new System.Drawing.Point(31, 269);
            this.lbl_AliquotaIRPF.Name = "lbl_AliquotaIRPF";
            this.lbl_AliquotaIRPF.Size = new System.Drawing.Size(72, 13);
            this.lbl_AliquotaIRPF.TabIndex = 10;
            this.lbl_AliquotaIRPF.Text = "Aliquota IRPF";
            // 
            // tbox_SalarioFamilia
            // 
            this.tbox_SalarioFamilia.Location = new System.Drawing.Point(130, 297);
            this.tbox_SalarioFamilia.Name = "tbox_SalarioFamilia";
            this.tbox_SalarioFamilia.Size = new System.Drawing.Size(100, 20);
            this.tbox_SalarioFamilia.TabIndex = 13;
            // 
            // lbl_SalarioFamilia
            // 
            this.lbl_SalarioFamilia.AutoSize = true;
            this.lbl_SalarioFamilia.Location = new System.Drawing.Point(31, 300);
            this.lbl_SalarioFamilia.Name = "lbl_SalarioFamilia";
            this.lbl_SalarioFamilia.Size = new System.Drawing.Size(74, 13);
            this.lbl_SalarioFamilia.TabIndex = 12;
            this.lbl_SalarioFamilia.Text = "Salário Familia";
            // 
            // tbox_SalarioLiquido
            // 
            this.tbox_SalarioLiquido.Location = new System.Drawing.Point(130, 331);
            this.tbox_SalarioLiquido.Name = "tbox_SalarioLiquido";
            this.tbox_SalarioLiquido.Size = new System.Drawing.Size(100, 20);
            this.tbox_SalarioLiquido.TabIndex = 15;
            // 
            // lbl_SalarioLiquido
            // 
            this.lbl_SalarioLiquido.AutoSize = true;
            this.lbl_SalarioLiquido.Location = new System.Drawing.Point(34, 334);
            this.lbl_SalarioLiquido.Name = "lbl_SalarioLiquido";
            this.lbl_SalarioLiquido.Size = new System.Drawing.Size(76, 13);
            this.lbl_SalarioLiquido.TabIndex = 14;
            this.lbl_SalarioLiquido.Text = "Salário Liquido";
            // 
            // tbox_DescontoINSS
            // 
            this.tbox_DescontoINSS.Location = new System.Drawing.Point(396, 236);
            this.tbox_DescontoINSS.Name = "tbox_DescontoINSS";
            this.tbox_DescontoINSS.Size = new System.Drawing.Size(100, 20);
            this.tbox_DescontoINSS.TabIndex = 17;
            this.tbox_DescontoINSS.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lbl_DescontoINSS
            // 
            this.lbl_DescontoINSS.AutoSize = true;
            this.lbl_DescontoINSS.Location = new System.Drawing.Point(297, 239);
            this.lbl_DescontoINSS.Name = "lbl_DescontoINSS";
            this.lbl_DescontoINSS.Size = new System.Drawing.Size(81, 13);
            this.lbl_DescontoINSS.TabIndex = 16;
            this.lbl_DescontoINSS.Text = "Desconto INSS";
            this.lbl_DescontoINSS.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbox_DescontoIRPF
            // 
            this.tbox_DescontoIRPF.Location = new System.Drawing.Point(396, 266);
            this.tbox_DescontoIRPF.Name = "tbox_DescontoIRPF";
            this.tbox_DescontoIRPF.Size = new System.Drawing.Size(100, 20);
            this.tbox_DescontoIRPF.TabIndex = 19;
            // 
            // lbl_DescontoIRPF
            // 
            this.lbl_DescontoIRPF.AutoSize = true;
            this.lbl_DescontoIRPF.Location = new System.Drawing.Point(297, 269);
            this.lbl_DescontoIRPF.Name = "lbl_DescontoIRPF";
            this.lbl_DescontoIRPF.Size = new System.Drawing.Size(80, 13);
            this.lbl_DescontoIRPF.TabIndex = 18;
            this.lbl_DescontoIRPF.Text = "Desconto IRPF";
            // 
            // grBox_Sexo
            // 
            this.grBox_Sexo.Controls.Add(this.cbox_Feminino);
            this.grBox_Sexo.Controls.Add(this.cbox_Masculino);
            this.grBox_Sexo.Location = new System.Drawing.Point(300, 43);
            this.grBox_Sexo.Name = "grBox_Sexo";
            this.grBox_Sexo.Size = new System.Drawing.Size(254, 42);
            this.grBox_Sexo.TabIndex = 21;
            this.grBox_Sexo.TabStop = false;
            this.grBox_Sexo.Text = "Sexo";
            // 
            // grBox_EstaoCivil
            // 
            this.grBox_EstaoCivil.Controls.Add(this.cbox_IsCasado);
            this.grBox_EstaoCivil.Location = new System.Drawing.Point(300, 101);
            this.grBox_EstaoCivil.Name = "grBox_EstaoCivil";
            this.grBox_EstaoCivil.Size = new System.Drawing.Size(254, 42);
            this.grBox_EstaoCivil.TabIndex = 22;
            this.grBox_EstaoCivil.TabStop = false;
            this.grBox_EstaoCivil.Text = "Estado Civil";
            // 
            // cbox_Masculino
            // 
            this.cbox_Masculino.AutoSize = true;
            this.cbox_Masculino.Location = new System.Drawing.Point(57, 19);
            this.cbox_Masculino.Name = "cbox_Masculino";
            this.cbox_Masculino.Size = new System.Drawing.Size(35, 17);
            this.cbox_Masculino.TabIndex = 21;
            this.cbox_Masculino.Text = "M";
            this.cbox_Masculino.UseVisualStyleBackColor = true;
            this.cbox_Masculino.CheckedChanged += new System.EventHandler(this.cbox_Masculino_CheckedChanged);
            // 
            // cbox_Feminino
            // 
            this.cbox_Feminino.AutoSize = true;
            this.cbox_Feminino.Location = new System.Drawing.Point(143, 19);
            this.cbox_Feminino.Name = "cbox_Feminino";
            this.cbox_Feminino.Size = new System.Drawing.Size(32, 17);
            this.cbox_Feminino.TabIndex = 22;
            this.cbox_Feminino.Text = "F";
            this.cbox_Feminino.UseVisualStyleBackColor = true;
            this.cbox_Feminino.CheckedChanged += new System.EventHandler(this.cbox_Feminino_CheckedChanged);
            // 
            // cbox_IsCasado
            // 
            this.cbox_IsCasado.AutoSize = true;
            this.cbox_IsCasado.Location = new System.Drawing.Point(57, 19);
            this.cbox_IsCasado.Name = "cbox_IsCasado";
            this.cbox_IsCasado.Size = new System.Drawing.Size(62, 17);
            this.cbox_IsCasado.TabIndex = 22;
            this.cbox_IsCasado.Text = "Casado";
            this.cbox_IsCasado.UseVisualStyleBackColor = true;
            // 
            // frm_CalculaAliquota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.grBox_EstaoCivil);
            this.Controls.Add(this.grBox_Sexo);
            this.Controls.Add(this.tbox_DescontoIRPF);
            this.Controls.Add(this.lbl_DescontoIRPF);
            this.Controls.Add(this.tbox_DescontoINSS);
            this.Controls.Add(this.lbl_DescontoINSS);
            this.Controls.Add(this.tbox_SalarioLiquido);
            this.Controls.Add(this.lbl_SalarioLiquido);
            this.Controls.Add(this.tbox_SalarioFamilia);
            this.Controls.Add(this.lbl_SalarioFamilia);
            this.Controls.Add(this.tbox_AliquotaIRPF);
            this.Controls.Add(this.lbl_AliquotaIRPF);
            this.Controls.Add(this.tbox_AliquotaINSS);
            this.Controls.Add(this.lbl_AliquotaINSS);
            this.Controls.Add(this.lbl_Mensagem);
            this.Controls.Add(this.btn_CalculaDesconto);
            this.Controls.Add(this.lbl_NumeroDeFilhos);
            this.Controls.Add(this.lbl_SalarioBruto);
            this.Controls.Add(this.nupd_NumeroFilhos);
            this.Controls.Add(this.mtbox_SalarioBruto);
            this.Controls.Add(this.tbox_Nome);
            this.Controls.Add(this.lbl_NomeFuncionario);
            this.Name = "frm_CalculaAliquota";
            this.Text = "Calculo de Aliquota";
            this.Load += new System.EventHandler(this.frm_CalculaAliquota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupd_NumeroFilhos)).EndInit();
            this.grBox_Sexo.ResumeLayout(false);
            this.grBox_Sexo.PerformLayout();
            this.grBox_EstaoCivil.ResumeLayout(false);
            this.grBox_EstaoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.TextBox tbox_Nome;
        private System.Windows.Forms.MaskedTextBox mtbox_SalarioBruto;
        private System.Windows.Forms.NumericUpDown nupd_NumeroFilhos;
        private System.Windows.Forms.Label lbl_SalarioBruto;
        private System.Windows.Forms.Label lbl_NumeroDeFilhos;
        private System.Windows.Forms.Button btn_CalculaDesconto;
        private System.Windows.Forms.Label lbl_Mensagem;
        private System.Windows.Forms.TextBox tbox_AliquotaINSS;
        private System.Windows.Forms.Label lbl_AliquotaINSS;
        private System.Windows.Forms.TextBox tbox_AliquotaIRPF;
        private System.Windows.Forms.Label lbl_AliquotaIRPF;
        private System.Windows.Forms.TextBox tbox_SalarioFamilia;
        private System.Windows.Forms.Label lbl_SalarioFamilia;
        private System.Windows.Forms.TextBox tbox_SalarioLiquido;
        private System.Windows.Forms.Label lbl_SalarioLiquido;
        private System.Windows.Forms.TextBox tbox_DescontoINSS;
        private System.Windows.Forms.Label lbl_DescontoINSS;
        private System.Windows.Forms.TextBox tbox_DescontoIRPF;
        private System.Windows.Forms.Label lbl_DescontoIRPF;
        private System.Windows.Forms.GroupBox grBox_Sexo;
        private System.Windows.Forms.CheckBox cbox_Feminino;
        private System.Windows.Forms.CheckBox cbox_Masculino;
        private System.Windows.Forms.GroupBox grBox_EstaoCivil;
        private System.Windows.Forms.CheckBox cbox_IsCasado;
    }
}

