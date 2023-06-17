using PContato0030482223003.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace PContato0030482223003.Formularios
{
    public partial class frmContato : Form
    {
        private BindingSource _bindingSourceContato = new BindingSource();
        private bool _inclusao = false;
        private DataSet _dataSetContato = new DataSet();
        private DataSet _dataSetCidade = new DataSet();
        public frmContato()
        {
            InitializeComponent();
        }

        private void frmContato_Load(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                _dataSetContato.Tables.Add(contato.Listar());
                _bindingSourceContato.DataSource = _dataSetContato.Tables["Contato"];
                dgvContato.DataSource = _bindingSourceContato;
                bnvContato.BindingSource = _bindingSourceContato;
                txtBoxIdContato.DataBindings.Add("TEXT", _bindingSourceContato, "id_contato");
                txtBoxNomeContato.DataBindings.Add("TEXT", _bindingSourceContato, "nome_contato");
                txtBoxEnderecoContato.DataBindings.Add("text", _bindingSourceContato, "end_contato");
                txtBoxCelularContato.DataBindings.Add("TEXT", _bindingSourceContato, "cel_contato");
                txtBoxEmailContato.DataBindings.Add("TEXT", _bindingSourceContato, "email_contato");
                dtPkDataContato.DataBindings.Add("TEXT", _bindingSourceContato, "dtcadastro_contato");
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;

                //carrega dados da cidade
                Cidade Cid = new Cidade();
                _dataSetCidade.Tables.Add(Cid.Listar());
                cmBoxCidadeContato.DataSource = _dataSetCidade.Tables["Cidade"];

                //campo que será mostrado para o usuário
                cmBoxCidadeContato.DisplayMember = "NOME_CIDADE";

                //campo que é a chave da tabela cidade e que liga com a tabela de contato
                cmBoxCidadeContato.ValueMember = "ID_CIDADE";

                //no momento de linkar os componente com o Binding Source linkar também o
                cmBoxCidadeContato.DataBindings.Add("SelectedValue", _bindingSourceContato,
                    "CIDADE_ID_CIDADE"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }

            _bindingSourceContato.AddNew();
            txtBoxNomeContato.Enabled = true;
            txtBoxEnderecoContato.Enabled = true;
            txtBoxCelularContato.Enabled = true;
            txtBoxEmailContato.Enabled = true;
            cmBoxCidadeContato.Enabled = true;
            dtPkDataContato.Enabled = true;
            cmBoxCidadeContato.SelectedItem = cmBoxCidadeContato.Items[0];
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            _inclusao = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNomeContato.Text) || txtBoxNomeContato.Text.Length < 10 )
            {
                MessageBox.Show("Favor inserir um nome válido!");
                txtBoxNomeContato.Focus();
            }
            else if(string.IsNullOrEmpty(txtBoxEnderecoContato.Text) || txtBoxEnderecoContato.Text.Length < 10)
            {
                MessageBox.Show("Favor inserir um endereço válido!");
                txtBoxEnderecoContato.Focus();
            }
            else if(string.IsNullOrEmpty(txtBoxCelularContato.Text) || txtBoxNomeContato.Text.Length < 10)
            {
                MessageBox.Show("Favor inserir um celular válido!");
                txtBoxCelularContato.Focus();
            }
            else if (string.IsNullOrEmpty(txtBoxEmailContato.Text) || txtBoxNomeContato.Text.Length < 10)
            {
                MessageBox.Show("Favor inserir um email válido!");
                txtBoxEmailContato.Focus();
            }
            else
            {
                Contato RegCont = new Contato();
                RegCont.IdContato = Convert.ToInt16(txtBoxIdContato.Text);
                RegCont.NomeContato = txtBoxNomeContato.Text;
                RegCont.EndContato = txtBoxEnderecoContato.Text;
                RegCont.CidadeIdContato = (int)cmBoxCidadeContato.SelectedValue;
                RegCont.CelContato = txtBoxCelularContato.Text;
                RegCont.EmailContato = txtBoxEmailContato.Text;
                RegCont.DataCadastroContato = Convert.ToDateTime(dtPkDataContato.Text);
                if (_inclusao)
                {
                    if (RegCont.Salvar() > 0)
                    {
                        MessageBox.Show("Contato adicionado com sucesso!");
                        txtBoxIdContato.Enabled = false;
                        txtBoxNomeContato.Enabled = false;
                        txtBoxEnderecoContato.Enabled = false;
                        cmBoxCidadeContato.Enabled = true;
                        txtBoxCelularContato.Enabled = false;
                        txtBoxEmailContato.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                        _inclusao = false;
                        // recarrega o grid
                        _dataSetContato.Tables.Clear();
                        _dataSetContato.Tables.Add(RegCont.Listar());
                        _bindingSourceContato.DataSource = _dataSetContato.Tables["Contato"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Contato!");
                    }
                }
                else
                {
                    if (RegCont.Alterar() > 0)
                    {
                        MessageBox.Show("Contato alterado com sucesso!");
                        _dataSetContato.Tables.Clear();
                        _dataSetContato.Tables.Add(RegCont.Listar());

                        // Formulário
                        txtBoxIdContato.Enabled = false;
                        txtBoxNomeContato.Enabled = false;
                        txtBoxEnderecoContato.Enabled = false;
                        cmBoxCidadeContato.Enabled = false;
                        txtBoxCelularContato.Enabled = false;
                        txtBoxEmailContato.Enabled = false;

                        // Menu
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Contato!");
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }

            // Formulário
            txtBoxIdContato.Enabled = false;
            txtBoxNomeContato.Enabled = true;
            txtBoxEnderecoContato.Enabled = true;
            cmBoxCidadeContato.Enabled = true;
            txtBoxCelularContato.Enabled = true;
            txtBoxEmailContato.Enabled = true;

            // Menu
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            _inclusao = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }

            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Contato RegCont = new Contato();
                RegCont.IdContato = Convert.ToInt16(txtBoxIdContato.Text);
                RegCont.NomeContato = txtBoxNomeContato.Text;
                RegCont.EndContato = txtBoxEnderecoContato.Text;
                RegCont.CelContato = txtBoxCelularContato.Text;
                RegCont.EmailContato = txtBoxEmailContato.Text;

                if (RegCont.Excluir() > 0)
                {
                    MessageBox.Show("Cidade excluída com sucesso!");
                    Contato R = new Contato();
                    _dataSetContato.Tables.Clear();
                    _dataSetContato.Tables.Add(R.Listar());
                    _bindingSourceContato.DataSource = _dataSetContato.Tables["Contato"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o contato!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _bindingSourceContato.CancelEdit();

            // Formulário
            txtBoxIdContato.Enabled = false;
            txtBoxNomeContato.Enabled = false;
            txtBoxEnderecoContato.Enabled = false;
            cmBoxCidadeContato.Enabled = false;
            txtBoxCelularContato.Enabled = false;
            txtBoxEmailContato.Enabled = false;

            // MENU
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
