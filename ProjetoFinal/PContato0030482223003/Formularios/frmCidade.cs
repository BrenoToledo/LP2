using System;
using System.Data;
using System.Windows.Forms;

namespace PContato0030482223003.Formularios
{
    public partial class frmCidade : Form
    {
        private BindingSource _bindingSourceCidade = new BindingSource();
        private bool _inclusao = false;
        private DataSet _dataSetCidade = new DataSet();

        public frmCidade()
        {
            InitializeComponent();
        }

        private void frmCidade_Load(object sender, EventArgs e)
        {
            try
            {
                Cidade cidade = new Cidade();
                _dataSetCidade.Tables.Add(cidade.Listar());
                _bindingSourceCidade.DataSource = _dataSetCidade.Tables["Cidade"];
                dgvCidade.DataSource = _bindingSourceCidade;
                bnvCidade.BindingSource = _bindingSourceCidade;
                txtId.DataBindings.Add("TEXT", _bindingSourceCidade, "id_cidade");
                txtNomeCidade.DataBindings.Add("TEXT", _bindingSourceCidade, "nome_cidade");
                cbxEstado.DataBindings.Add("SelectedItem", _bindingSourceCidade, "uf_cidade"); // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR INCLUIR
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }

            _bindingSourceCidade.AddNew();
            txtNomeCidade.Enabled = true;
            cbxEstado.Enabled = true;
            cbxEstado.SelectedIndex = 0;
            txtNomeCidade.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            _inclusao = true; ;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }

            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Cidade RegCid = new Cidade();
                RegCid.Idcidade = Convert.ToInt16(txtId.Text);
                RegCid.Nomecidade = txtNomeCidade.Text;
                RegCid.Ufcidade = cbxEstado.SelectedItem.ToString();
                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Cidade excluída com sucesso!");
                    Cidade R = new Cidade();
                    _dataSetCidade.Tables.Clear();
                    _dataSetCidade.Tables.Add(R.Listar());
                    _bindingSourceCidade.DataSource = _dataSetCidade.Tables["Cidade"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cidade!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }

            txtNomeCidade.Enabled = true;
            cbxEstado.Enabled = true;
            txtNomeCidade.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            _inclusao = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txtNomeCidade.Text)) || (txtNomeCidade.Text.Length < 3 ))
            {
                MessageBox.Show("Cidade inválida!");
            }
            else
            {
                Cidade RegCid = new Cidade();
                RegCid.Idcidade = Convert.ToInt16(txtId.Text);
                RegCid.Nomecidade = txtNomeCidade.Text;
                RegCid.Ufcidade = cbxEstado.SelectedItem.ToString();
                if (_inclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Cidade adicionada com sucesso!");
                        txtId.Enabled = false;
                        txtNomeCidade.Enabled = false;
                        cbxEstado.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                        _inclusao = false;
                        // recarrega o grid
                        _dataSetCidade.Tables.Clear();
                        _dataSetCidade.Tables.Add(RegCid.Listar());
                        _bindingSourceCidade.DataSource = _dataSetCidade.Tables["Cidade"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }
                }
                else
                {
                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Cidade alterada com sucesso!");
                        _dataSetCidade.Tables.Clear();
                        _dataSetCidade.Tables.Add(RegCid.Listar());
                        txtId.Enabled = false;
                        txtNomeCidade.Enabled = false;
                        cbxEstado.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _bindingSourceCidade.CancelEdit();
            btnSalvar.Enabled = false;
            txtNomeCidade.Enabled = false;
            cbxEstado.Enabled = false;
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
